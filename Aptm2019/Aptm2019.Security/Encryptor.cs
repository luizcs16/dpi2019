using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aptm2019.Security
{
    public class Encryptor
    {
        public static void EncryptDataSet(DataSet ds, string path)
        {
            DES des = new DESCryptoServiceProvider();
            using (StreamWriter sw = new StreamWriter(Path.Combine(path, "DES.bin")))
            {
                BinaryFormatter bf = new BinaryFormatter();
                byte[][] stuff = new byte[2][];
                stuff[0] = des.Key;
                stuff[1] = des.IV;
                bf.Serialize(sw.BaseStream, stuff);
            }

            using (FileStream fs = new FileStream(Path.Combine(path, "DATA.xml"), FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                using (CryptoStream cs = new CryptoStream(fs, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(ds.GetXml());
                    }
                }
            }
            ds.WriteXmlSchema(Path.Combine(path, "ESQUEMA.xsd"));
        }

        public static DataSet DecryptDataSet(string path)
        {
            DataSet ds = new DataSet();
            DES des = new DESCryptoServiceProvider();
            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(path, "DES.bin")))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    byte[][] stuff = (byte[][])bf.Deserialize(sr.BaseStream);
                    des.Key = stuff[0];
                    des.IV = stuff[1];
                }

                ds.ReadXmlSchema(Path.Combine(path, "ESQUEMA.xsd"));

                using (FileStream fs = new FileStream(Path.Combine(path, "DATA.xml"), FileMode.Open, FileAccess.Read))
                {
                    using (CryptoStream cs = new CryptoStream(fs, des.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        ds.ReadXml(cs);
                    }
                }

                return ds;
            }
            catch
            {
                return null;
            }
            finally
            {
                des.Dispose();
                des = null;
                ds.Dispose();
                ds = null;
            }
        }

        public static string EncryptTripleDES(string Plaintext, string strKey)
        {
            if (Plaintext.Trim().Length <= 0) return string.Empty;
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            DES.Key = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strKey));
            DES.Mode = System.Security.Cryptography.CipherMode.ECB;
            ICryptoTransform DESEncrypt = DES.CreateEncryptor();
            byte[] Buffer = ASCIIEncoding.ASCII.GetBytes(Plaintext);
            return System.Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }

        public static string EncryptTripleDES(string Plaintext, string strKey, byte[] IV)
        {
            TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            DES.Key = hashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strKey));
            DES.Mode = System.Security.Cryptography.CipherMode.CBC;
            DES.IV = IV;
            ICryptoTransform DESEncrypt = DES.CreateEncryptor();
            byte[] Buffer = ASCIIEncoding.ASCII.GetBytes(Plaintext);
            return System.Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
        }

        public static string DecryptTripleDES(string base64Text, string strKey)
        {
            if (base64Text.Trim() != string.Empty && strKey.Trim() != string.Empty)
            {
                TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
                DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(strKey));
                DES.Mode = CipherMode.ECB;
                ICryptoTransform DESDecrypt = DES.CreateDecryptor();
                byte[] Buffer = System.Convert.FromBase64String(base64Text);
                return ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            else
            {
                return string.Empty;
            }
        }

        public static string DecryptTripleDES(string base64Text, string strKey, byte[] IV)
        {
            if (base64Text.Trim() != string.Empty && strKey.Trim() != string.Empty)
            {
                TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
                DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(strKey));
                DES.Mode = CipherMode.CBC;
                DES.IV = IV;
                ICryptoTransform DESDecrypt = DES.CreateDecryptor();
                byte[] Buffer = System.Convert.FromBase64String(base64Text);
                return ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length));
            }
            else
            {
                return string.Empty;
            }
        }

        public static string Sha1(string txtText)
        {
            SHA1 sha = SHA1Managed.Create();
            StringBuilder outString = new StringBuilder();
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] hash = sha.ComputeHash(encoder.GetBytes(txtText));
            for (int i = 0; i < hash.Length; i++)
            {
                outString.AppendFormat("{0:x2}", hash[i]);
            }
            return outString.ToString();

        }

        public static string RandomString(int LEN_SALT)
        {
            RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
            StringBuilder builder = new StringBuilder();
            byte[] salt = new byte[LEN_SALT];
            csprng.GetNonZeroBytes(salt);
            for (int i = 0; i < salt.Length; i++)
            {
                builder.AppendFormat("{0:x2}", salt[i]);
            }
            return builder.ToString();
        }

        public static byte[] RandomBytes(int LEN_BYTES)
        {
            RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
            StringBuilder builder = new StringBuilder();
            byte[] bytes = new byte[LEN_BYTES];
            csprng.GetNonZeroBytes(bytes);

            return bytes;
        }

        public static string Bytes2Hex(byte[] bytes)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.AppendFormat("{0:x2}", bytes[i]);
            }

            return builder.ToString();
        }

        public static byte[] Hex2Bytes(string strHex)
        {
            return Enumerable.Range(0, strHex.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(strHex.Substring(x, 2), 16))
                     .ToArray();
        }

        public static string EncryptHashValue(string PlainText)
        {
            string sHash;

            byte[] bytText = ConvertTo.ConvertStringToByteArray(PlainText);
            byte[] bytHash = (new MD5CryptoServiceProvider()).ComputeHash(bytText);

            sHash = BitConverter.ToString(bytHash);
            return sHash;


        }
    }
    public sealed class ConvertTo
    {
        public static byte[] ConvertStringToByteArray(string s)
        {
            return (new UnicodeEncoding()).GetBytes(s);
        }
    }

}
