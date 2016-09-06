using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Tools
{
   public  class MD5Crypto
    {
       
        // Verilen string'i md5'e çeviren fonksiyon.
        #region Method Overloading-Str veya Str-Key e Gore Md5 Sifreleme 
        public static string Convert(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));
            System.Text.StringBuilder builder = new System.Text.StringBuilder();

            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2").ToLower());
            }

            return builder.ToString();
        }

      
        // Verilen string'i key ile birlikte md5'e çeviren fonksiyon.
        public static string Convert(string str, string key)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(str);

            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock
            (toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return System.Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        #endregion

    }
}
