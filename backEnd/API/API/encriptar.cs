using System.Text;
using System.Security.Cryptography;

namespace adConjuntos2
{
    public class encriptar
    {
        public string Encriptar(string cadena)
        {
            byte[] BtclearBytes;
            BtclearBytes = new UnicodeEncoding().GetBytes(cadena);
            byte[] BthashedBytes = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(BtclearBytes);
            string sthashedText = BitConverter.ToString(BthashedBytes);

            return sthashedText;
        }
    }
}
