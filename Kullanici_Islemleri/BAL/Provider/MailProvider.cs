using BAL.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Provider
{
  public  class MailProvider
  {
      #region Mail icin Konu,baslık,mailadres Işlemleri
      public string SendActivationCode(string activationKey, string mail)
      {
          string err = "";

          string content = "Asagıdaki Linki Tıklayarak Sifrenizi Guncelleyebilirsiniz.<br/><br/>"+ Helper.GetSiteRoot() + "/Account/ActivasyonKey/" + activationKey;//guid degerle urettigim activasyon linki yani mehmettokak.com/Account/ActivationKey/xxxxxxxxxxxx  gibi X=>guidle urettıgımız deger
          string subject = "Sifre Guncelleme";
          MailSender mp = new MailSender();
          string result = mp.Send(mail, subject, content);
          if (result == "0")
          {
              err = "Sifre Gönderme hatası!!!";
          }
          return err;
      }
      #endregion
  }
}
