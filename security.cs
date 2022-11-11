using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SuperMaket_project
{
    internal class security
    {
        string hash = "ahmed@3118";
        byte[] data, result;
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
        ICryptoTransform cryptoTransform;
        public string Encrypt(String encrypt)
        {
            data = UTF8Encoding.UTF8.GetBytes(encrypt);

            md5 = new MD5CryptoServiceProvider();
            tripDes = new TripleDESCryptoServiceProvider();
            tripDes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripDes.Mode = CipherMode.ECB;
            cryptoTransform = tripDes.CreateEncryptor();
            result = cryptoTransform.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(result);
        }
        //            Decrypt 
        public string Decrypt(string Decrypt)
        {
            data = Convert.FromBase64String(Decrypt);
            md5 = new MD5CryptoServiceProvider();
            tripDes = new TripleDESCryptoServiceProvider();
            tripDes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripDes.Mode = CipherMode.ECB;
            cryptoTransform = tripDes.CreateDecryptor();
            result = cryptoTransform.TransformFinalBlock(data, 0, data.Length);
            return UTF8Encoding.UTF8.GetString(result);
        }
    }
}
