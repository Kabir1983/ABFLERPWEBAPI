using System.Security.Cryptography;
using System.Text;

namespace ABFLERPWEBAPI.Common
{
    public class HashValue
    {
        private static string SecuredKey = "shamim";

        public static string GetHashValue(string plainText, byte[] saltBytes)
        {
            if (saltBytes == null)
            {
                saltBytes = new byte[new Random().Next(4, 8)];
                new RNGCryptoServiceProvider().GetNonZeroBytes(saltBytes);
            }
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);
            byte[] buffer = new byte[bytes.Length + saltBytes.Length];
            for (int index = 0; index < bytes.Length; ++index)
                buffer[index] = bytes[index];
            for (int index = 0; index < saltBytes.Length; ++index)
                buffer[bytes.Length + index] = saltBytes[index];
            byte[] hash = new SHA1Managed().ComputeHash(buffer);
            byte[] inArray = new byte[hash.Length + saltBytes.Length];
            for (int index = 0; index < hash.Length; ++index)
                inArray[index] = hash[index];
            for (int index = 0; index < saltBytes.Length; ++index)
                inArray[hash.Length + index] = saltBytes[index];
            return Convert.ToBase64String(inArray);
        }

        public static string Encrypt(string toEncrypt)
        {
            byte[] bytes1 = Encoding.UTF8.GetBytes(toEncrypt);
            string securedKey = HashValue.SecuredKey;
            MD5CryptoServiceProvider cryptoServiceProvider1 = new MD5CryptoServiceProvider();
            byte[] bytes2 = Encoding.UTF8.GetBytes(securedKey);
            byte[] hash = cryptoServiceProvider1.ComputeHash(bytes2);
            cryptoServiceProvider1.Clear();
            TripleDESCryptoServiceProvider cryptoServiceProvider2 = new TripleDESCryptoServiceProvider();
            byte[] numArray = hash;
            cryptoServiceProvider2.Key = numArray;
            int num1 = 2;
            cryptoServiceProvider2.Mode = (CipherMode)num1;
            int num2 = 2;
            cryptoServiceProvider2.Padding = (PaddingMode)num2;
            byte[] inArray = cryptoServiceProvider2.CreateEncryptor().TransformFinalBlock(bytes1, 0, bytes1.Length);
            cryptoServiceProvider2.Clear();
            return Convert.ToBase64String(inArray, 0, inArray.Length);
        }

        public static string Decrypt(string cipherString)
        {
            byte[] inputBuffer = Convert.FromBase64String(cipherString);
            string securedKey = HashValue.SecuredKey;
            MD5CryptoServiceProvider cryptoServiceProvider1 = new MD5CryptoServiceProvider();
            byte[] bytes1 = Encoding.UTF8.GetBytes(securedKey);
            byte[] hash = cryptoServiceProvider1.ComputeHash(bytes1);
            cryptoServiceProvider1.Clear();
            TripleDESCryptoServiceProvider cryptoServiceProvider2 = new TripleDESCryptoServiceProvider();
            byte[] numArray = hash;
            cryptoServiceProvider2.Key = numArray;
            int num1 = 2;
            cryptoServiceProvider2.Mode = (CipherMode)num1;
            int num2 = 2;
            cryptoServiceProvider2.Padding = (PaddingMode)num2;
            byte[] bytes2 = cryptoServiceProvider2.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
            cryptoServiceProvider2.Clear();
            return Encoding.UTF8.GetString(bytes2);
        }

        public static bool VerifyHash(string plainText, string hashValue)
        {
            byte[] numArray = Convert.FromBase64String(hashValue);
            int num = 160 / 8;
            if (numArray.Length < num)
                return false;
            byte[] saltBytes = new byte[numArray.Length - num];
            for (int index = 0; index < saltBytes.Length; ++index)
                saltBytes[index] = numArray[num + index];
            string hashValue1 = HashValue.GetHashValue(plainText, saltBytes);
            return hashValue == hashValue1;
        }

        public static string RetrivePlainText(string hashValue)
        {
            string str = "";
            byte[] numArray1 = Convert.FromBase64String(hashValue);
            int num = 160 / 8;
            SHA1Managed shA1Managed = new SHA1Managed();
            byte[] numArray2 = new byte[numArray1.Length - num];
            for (int index = 0; index < numArray2.Length; ++index)
                numArray2[index] = numArray1[num + index];
            return str;
        }
    }
}
