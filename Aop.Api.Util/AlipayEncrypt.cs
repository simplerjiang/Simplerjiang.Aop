using System;
using System.Security.Cryptography;
using System.Text;

namespace Aop.Api.Util
{
	internal class AlipayEncrypt
	{
		private static byte[] AES_IV = initIv(16);

		public static string AesEncrypt(string encryptKey, string bizContent, string charset)
		{
			byte[] key = Convert.FromBase64String(encryptKey);
			byte[] array = null;
			array = ((!string.IsNullOrEmpty(charset)) ? Encoding.GetEncoding(charset).GetBytes(bizContent) : Encoding.UTF8.GetBytes(bizContent));
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = key;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.IV = AES_IV;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			byte[] inArray = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
			return Convert.ToBase64String(inArray);
		}

		public static string AesDencrypt(string encryptKey, string bizContent, string charset)
		{
			byte[] key = Convert.FromBase64String(encryptKey);
			byte[] array = Convert.FromBase64String(bizContent);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = key;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.IV = AES_IV;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
			if (string.IsNullOrEmpty(charset))
			{
				return Encoding.UTF8.GetString(bytes);
			}
			return Encoding.GetEncoding(charset).GetString(bytes);
		}

		private static byte[] initIv(int blockSize)
		{
			byte[] array = new byte[blockSize];
			for (int i = 0; i < blockSize; i++)
			{
				array[i] = 0;
			}
			return array;
		}
	}
}
