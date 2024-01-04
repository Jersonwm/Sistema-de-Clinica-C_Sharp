using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_DAE.Clases
{
     class Encriptar
    {
        private TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
        private MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();

        private byte[] MD5Hash(string value)
        {
            return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value));
        }

        public string encriptar(string textoaCodificar, string key)
        {
            DES.Key = this.MD5Hash(key);
            DES.Mode = CipherMode.ECB;
            byte[] buffer = ASCIIEncoding.ASCII.GetBytes(textoaCodificar);
            return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer,0,buffer.Length));
        }

        public string desencriptar(string textoaDescodificar, string key)
        {
            try
            {
                DES.Key = this.MD5Hash(key);
                DES.Mode = CipherMode.ECB;
                byte[] buffer = ASCIIEncoding.ASCII.GetBytes(textoaDescodificar);
                return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buffer,0,buffer.Length));
            }
            catch (Exception ex)
            {

                return "error al desencriptar la clave, verifique la imformación";
            }
        }
    }
}
