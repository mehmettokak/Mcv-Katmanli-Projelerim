using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Tools
{
   public class MailSender
   {
       #region Propertyler
       public string gUserName { get; set; }
        public string gPassword { get; set; }
        public string gHost { get; set; }
        public string gFromMail { get; set; }
        public string gFromName { get; set; }
       #endregion

        #region Mail Kullanici Bilgileri
        public MailSender()
        {
            gUserName = Settings.GetSetting("gUserName");
            gPassword = Settings.GetSetting("gPassword");
            gHost = Settings.GetSetting("gHost");
            gFromMail = gUserName;
            gFromName = "Mehmet TOKAK";
        }
        #endregion

        #region Mail Gönderme Islemleri
        public string Send(string To, string Subject, string Body)
        {
            string durum = "0";
            NetworkCredential MailCredential = new NetworkCredential();
            MailCredential.UserName = gUserName;
            MailCredential.Password = gPassword;

            SmtpClient MailClient = new SmtpClient();
            MailClient.Host = gHost;
            MailClient.Port = 587;
            MailClient.EnableSsl = false;
            MailClient.Credentials = MailCredential;

            MailAddress Recipent = new MailAddress(To, "");
            MailAddress Sender = new MailAddress(gFromMail, gFromName);
            MailMessage MailMsg = new MailMessage(Sender, Recipent);
            MailMsg.From = Sender;
            MailMsg.Subject = Subject;
            MailMsg.IsBodyHtml = true;
            MailMsg.Body = Body;

            try
            {
                MailClient.Send(MailMsg);
                durum = "1";
            }
            catch (Exception)
            {
                durum = "0";

            }
            return durum;

        }
        #endregion
    }
}
