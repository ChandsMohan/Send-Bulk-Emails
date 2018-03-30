using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendEmails
{
    public partial class frmSendEmail : Form
    {
        #region Private Members.....
        private static string ExcelExtension;
        private static string ResumeExtension;
        private static string ResumeFileName;
        private static string ResumeFilePath { get; set; }
        private static string ExcelConString { get; set; }
        private static string ExcelPath { get; set; }
        private static DataSet DataTrans { get; set; }
        private static DataTable DtSingaporeEmails { get; set; }
        private static DataTable DtOtherEmails { get; set; }
        private static string SMTPServer { get; set; }
        private static int SMTPPortNo { get; set; }
        private static string SMTPEmailID { get; set; }
        private static string SMTPPassword { get; set; }
        #endregion Private Members.....

        public frmSendEmail()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------//

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Mohan: set SMTP settimg to send email
            SMTPServer = txtSMTPServer.Text.Trim();
            SMTPPortNo = Convert.ToInt16(txtPortNo.Text.Trim());
            SMTPEmailID = txtEmail.Text.Trim();
            SMTPPassword = txtPwd.Text.Trim();

            //Mohan: Employer name and Email ID
            string EmployerName = string.Empty;
            string Gender = string.Empty;
            string EmailId = string.Empty;

            SendEmail oSendEmail = new SendEmail();
            switch (ExcelExtension)
            {
                case ".xls": //Excel 97-03
                    ExcelConString = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
                    break;
                case ".xlsx": //Excel 07
                    ExcelConString = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
                    break;
                default:
                    break;
            }

            bool IsSuccess = ExportToDataTable(ExcelPath, ExcelExtension, ExcelConString, "Yes");
            if (IsSuccess)
            {
                if (DtSingaporeEmails.Rows.Count > 0)
                {
                    #region Send Emails to Singapore Employer....
                    if (DtSingaporeEmails.Columns.Contains("Name"))
                    {
                        foreach (DataRow row in DtSingaporeEmails.Rows)
                        {
                            EmployerName = Convert.ToString(row["Name"]);

                            if (DtSingaporeEmails.Columns.Contains("Gender"))
                            {
                                Gender = Convert.ToString(row["Gender"]);
                            }
                            EmailId = Convert.ToString(row["Email Id"]);
                            bool IsValidEmailId = IsValidEmail(EmailId);
                            if (IsValidEmailId)
                            {
                                oSendEmail.SendEmailwithResume(SMTPServer, SMTPPortNo, SMTPEmailID, EmployerName, Gender, EmailId, SMTPPassword, ResumeFilePath, true);
                            }
                        }
                    }
                    else
                    {
                        List<string> lstEmailId = DtSingaporeEmails.Rows.Cast<DataRow>().Select(a => a.Field<string>("Email Id")).Distinct().ToList();
                        foreach (var item in lstEmailId)
                        {
                            EmailId = Convert.ToString(item.Trim());
                            bool IsValidEmailId = IsValidEmail(EmailId);
                            if (IsValidEmailId)
                            {
                                oSendEmail.SendEmailwithResume(SMTPServer, SMTPPortNo, SMTPEmailID, EmployerName, Gender, EmailId, SMTPPassword, ResumeFilePath, true);
                            }
                        }
                    }
                    #endregion Send Emails to Singapore Employer....
                }

                if (DtOtherEmails.Rows.Count > 0)
                {
                    #region Send Emails to Other Employer....
                    if(DtOtherEmails.Columns.Contains("Name"))
                    {
                        foreach (DataRow item in DtOtherEmails.Rows)
                        {
                            EmployerName = Convert.ToString(item["Name"]);

                            if(DtOtherEmails.Columns.Contains("Gender"))
                            {
                                Gender = Convert.ToString(item["Gender"]);
                            }
                            EmailId = Convert.ToString(item["Email Id"]);
                            bool IsValidEmailId = IsValidEmail(EmailId);
                            if (IsValidEmailId)
                            {
                                oSendEmail.SendEmailwithResume(SMTPServer, SMTPPortNo, SMTPEmailID, EmployerName, Gender, EmailId, SMTPPassword, ResumeFilePath, true);
                            }
                        }
                    }
                    else
                    {
                        List<string> lstEmailId = DtOtherEmails.Rows.Cast<DataRow>().Select(a => a.Field<string>("Email Id")).Distinct().ToList();
                        foreach (var item in lstEmailId)
                        {
                            EmailId = Convert.ToString(item.Trim());
                            bool IsValidEmailId = IsValidEmail(EmailId);
                            if (IsValidEmailId)
                            {
                                oSendEmail.SendEmailwithResume(SMTPServer, SMTPPortNo, SMTPEmailID, EmployerName, Gender, EmailId, SMTPPassword, ResumeFilePath, false);
                            }
                        }
                    }                                        
                    #endregion Send Emails to Other Employer....
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------//

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Title = "Select a file";
            OpenFileDialog.InitialDirectory = @"C:\";
            OpenFileDialog.Filter = "Excel File|*.xls;*.xlsx;";
            OpenFileDialog.FileName = "Select a file";
            DialogResult result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtAttachExcel.Text = OpenFileDialog.FileName;
                ExcelExtension = Path.GetExtension(txtAttachExcel.Text);
                if (ExcelExtension.ToUpper() == ".XLSX" || ExcelExtension.ToUpper() == ".XLS")
                {
                    ExcelPath = txtAttachExcel.Text;
                }
                else
                {
                    MessageBox.Show("Please make sure your excel extension either .xls or .xlsx", "Email Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------//

        private void btnAttachResume_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Title = "Select a file";
            OpenFileDialog.InitialDirectory = @"C:\";
            OpenFileDialog.Filter = "Word File|*.doc;*.docx;*.pdf;";
            OpenFileDialog.FileName = "Select a file";
            DialogResult result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtAttachResume.Text = OpenFileDialog.FileName;
                ResumeExtension = Path.GetExtension(txtAttachResume.Text);
                if (ResumeExtension.ToUpper() == ".DOC" || ResumeExtension.ToUpper() == ".DOCX" || ResumeExtension.ToUpper() == ".PDF")
                {
                    ResumeFileName = Path.GetFileName(txtAttachResume.Text); //get file name with extension
                    ResumeFilePath = txtAttachResume.Text;
                }
                else
                {
                    MessageBox.Show("Please make sure your resume extension either .doc or .docx or .pdf", "Attach Resume", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------//

        #region Converting Excel to DataSet.........

        public bool ExportToDataTable(string ExcelPath, string Extension, string ExcelConn, string isHDR)
        {
            try
            {
                ExcelConn = String.Format(ExcelConn, ExcelPath, isHDR);
                DataSet DataSet = new DataSet();
                foreach (var sheetName in GetExcelSheetNames(ExcelConn))
                {
                    if (sheetName == "SingaporeEmails$" || sheetName == "OtherEmails$")
                    {
                        using (OleDbConnection con = new OleDbConnection(ExcelConn))
                        {
                            var dataTable = new DataTable();
                            dataTable.TableName = sheetName;
                            string query = string.Format("SELECT * FROM [{0}]", sheetName);
                            con.Open();
                            OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                            adapter.Fill(dataTable);
                            DataSet.Tables.Add(dataTable);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please make sure your excel sheet name :\n 1. Customers :\n 2.Transactions :\n 3.Receipt");
                        return false;
                    }

                }
                DataTrans = DataSet;
                DtSingaporeEmails = DataTrans.Tables["SingaporeEmails$"];
                DtOtherEmails = DataTrans.Tables["OtherEmails$"];
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------//

        public static string[] GetExcelSheetNames(string ExcelConnString)
        {
            OleDbConnection connection = null;
            DataTable dt = null;
            connection = new OleDbConnection(ExcelConnString);
            connection.Open();
            dt = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            if (dt == null)
            {
                return null;
            }

            String[] excelSheetNames = new String[dt.Rows.Count];
            int i = 0;

            foreach (DataRow row in dt.Rows)
            {
                excelSheetNames[i] = row["TABLE_NAME"].ToString();
                i++;
            }

            return excelSheetNames;
        }

        //-------------------------------------------------------------------------------------------------------------------------------//

        #endregion Converting Excel to DataSet.........

        //-----------------------------------------------------------------------------------------------------------------------------------//

        public bool IsValidEmail(string EmailId)
        {
            bool IsValidEmail = false;
            //System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9] [\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (EmailId.Length > 0)
            {
                if (rEmail.IsMatch(EmailId))
                {
                    IsValidEmail = true;
                }
            }
            return IsValidEmail;
        }
    }
}
