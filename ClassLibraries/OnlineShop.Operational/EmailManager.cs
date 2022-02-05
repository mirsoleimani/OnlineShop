using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Configuration;

namespace OnlineShop.Operational
{
    public class EmailManager
    {
        private bool _isSent;

   

        public void Send(EmailContents emailContents)
        {
            SmtpClient client = new SmtpClient(SMTPServerName);
            client.UseDefaultCredentials = true;
            MailAddress from = new MailAddress(emailContents.FromAddress, emailContents.FromName);
            MailAddress to = new MailAddress(ToAddress);
            MailMessage message = new MailMessage(from, to);
            message.Subject = emailContents.Subject;
            message.Body = Utilities.FormatText(emailContents.Body, true);
            message.IsBodyHtml = true;

            
            try
            {
                client.Send(message);
                IsSent = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private string SMTPServerName
        {
            get 
            {
                return ConfigurationManager.AppSettings["SMTPServer"]; 
            }
        }
        public bool IsSent
        {
            get { return _isSent; }
            set { _isSent = value; }
        }
        private string ToAddress
        {
            get { return ConfigurationManager.AppSettings["ToAddress"]; }
        }

    }
    public struct EmailContents
    {
        public string To;
        public string FromName;
        public string FromAddress;
        public string Subject;
        public string Body;
    }
}
