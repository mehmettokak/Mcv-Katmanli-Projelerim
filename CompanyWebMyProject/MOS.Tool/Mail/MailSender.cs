using CompanyWeb.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace CompanyWeb.Tool.Mail
{
    public class MailSender
    {
        public string gUserName { get; set; }
        public string gPassword { get; set; }
        public string gHost { get; set; }
        public string gFromMail { get; set; }
        public string gFromName { get; set; }

        public MailSender()
        {
            gUserName = Settings.GetSetting("gUserName");
            gPassword = Settings.GetSetting("gPassword");
            gHost = Settings.GetSetting("gHost");
            gFromMail = gUserName;
            
        }
    
        public string Send(Contact model)
        {
            string durum = "Başarılı.";
            NetworkCredential MailCredential = new NetworkCredential();
            MailCredential.UserName = gUserName;
            MailCredential.Password = gPassword;

            SmtpClient MailClient = new SmtpClient();
            MailClient.Host = gHost;
            MailClient.Port = 587;
            MailClient.EnableSsl = false;
            MailClient.Credentials = MailCredential;

            MailAddress Recipent = new MailAddress(gFromMail,model.NameSurName);
            MailAddress Sender = new MailAddress(gFromMail, model.Email);
            MailMessage MailMsg = new MailMessage(Sender, Recipent);
            MailMsg.From = Sender;
            MailMsg.Subject = model.Subject;
            MailMsg.IsBodyHtml = true;
            MailMsg.Body = model.Message;

            try
            {
                MailClient.Send(MailMsg);
                
            }
            catch (Exception)
            {
                durum = "Başarısız.";

            }
            return durum;

        }
    }
}
