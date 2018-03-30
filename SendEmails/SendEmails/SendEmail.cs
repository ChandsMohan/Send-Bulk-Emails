using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendEmails
{
    public class SendEmail
    {
        public void SendEmailwithResume(string SMTPServer, int Port, string FromEmail, string EmployerName, string Gender, string ToEmail, string Password, string ResumeFilePath, bool IsSingaporeEmail)
        {
            SmtpClient smtp = new SmtpClient();

            try
            {
                MailMessage message = new MailMessage(FromEmail, ToEmail);
                #region Network Settings
                smtp.Host = SMTPServer;
                smtp.Port = Port;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();
                credentials.UserName = FromEmail;
                credentials.Password = Password;
                smtp.Credentials = credentials;

                #endregion Network Settings
                string Subject = "Mohan Chandra Resume";
                StringBuilder strBody = new StringBuilder();

                #region  Commented Code.....
                //if(EmployerName != string.Empty || EmployerName == "Dear Sir")
                //{
                //    strBody.Append("Dear Friend, " + "<br/>" + "<br/>");
                //    strBody.Append("Please find the attached doc, I got your email Id from linkedin <br /> ");
                //}
                //else
                //{

                //}
                #endregion Commented Code.....

                if (Gender == "Male")
                {
                    strBody.Append("Dear Sir, " + "<br/>" + "<br/>");
                    strBody.Append("Please find the attached doc, I got your email Id from linkedin <br /> ");
                }
                else if(Gender == "Female")
                {
                    strBody.Append("Dear Mam, " + "<br/>" + "<br/>");
                    strBody.Append("Please find the attached doc, I got your email Id from linkedin <br /> ");
                }
                else
                {
                    strBody.Append("Dear Friend, " + "<br/>" + "<br/>");
                    strBody.Append("Please find the attached doc, I got your email Id from linkedin <br /> ");
                }

                if (IsSingaporeEmail)
                {
                    strBody.Append("I am looking for an opportunity from Singapore, Currently I am working as a dot net developer in product based company. <br />");
                    strBody.Append("It's my dream to be in Singapore and work in reputed and growing company, so I am looking for an employer who can sponsor my visa. <br />");
                    strBody.Append("I am waiting to become my dream come true, looking forward to hear from you.  <br />");
                    strBody.Append("<br />");
                }
                else
                {
                    strBody.Append("I am looking for an opportunity from abroad, Currently I am working as a dot net developer in product based company. <br /> ");
                    strBody.Append("Its my dream to work in a reputed and growing company so I am looking for an employer who can sponsor my visa. <br />");
                    strBody.Append("I am waiting to become my dream come true, looking forward to hear from you.  <br />");
                    strBody.Append("<br />");
                }

                //Mohan: Signature at the end of Email Body
                strBody.Append("- <br /> ");
                strBody.Append("Thanks and kind regards <br /> ");
                strBody.Append("Mohan Chandra <br /> ");
                strBody.Append("Mobile No - +91-9980398472, +91-9019674054 <br /> ");
                strBody.Append("Skype - manojkandpal192 <br /> ");
                strBody.Append("Whats App - +91-9019674054");

                message.Body = strBody.ToString();
                message.IsBodyHtml = true;
                message.Subject = Subject;
                message.Attachments.Add(new Attachment(ResumeFilePath));
                //Mohan : by pass Certificate Validation 
                System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
                System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                System.Security.Cryptography.X509Certificates.X509Chain chain,
                System.Net.Security.SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
                smtp.Send(message);
                smtp.Dispose();
            }
            catch (Exception Ex)
            {
                smtp.Dispose();
            }
        }
    }
}
