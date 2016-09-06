using System.Security.Cryptography;
using System.Text;

namespace CompanyWeb.Tool.Crypto
{
    public class Md5
    {
        /// <summary>
        /// Verilen string'i md5'e çeviren fonksiyon.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Verilen string'i key ile birlikte md5'e çeviren fonksiyon.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="key"></param>
        /// <returns></returns>
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
    }
}
