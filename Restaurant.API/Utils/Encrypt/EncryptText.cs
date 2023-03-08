using System.Security.Cryptography;
using System.Text;

namespace Restaurant.API.Utils.Encrypt
{
    public static class EncryptText
    {
        public static string EncryptSHA256(string text)
        {
            StringBuilder sb = new StringBuilder();

            SHA256 hmacSHA256 = SHA256.Create();
            byte[] stream = hmacSHA256.ComputeHash(Encoding.UTF8.GetBytes(text));

            for (int i = 0; i < stream.Length ; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }
            return sb.ToString();
        }
    }
}
