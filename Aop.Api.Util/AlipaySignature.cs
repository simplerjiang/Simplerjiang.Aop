using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Aop.Api.Util
{
	public class AlipaySignature
	{
		private static string DEFAULT_CHARSET = "GBK";

		public static string GetSignContent(IDictionary<string, string> parameters)
		{
			IDictionary<string, string> dictionary = new SortedDictionary<string, string>(parameters);
			IEnumerator<KeyValuePair<string, string>> enumerator = dictionary.GetEnumerator();
			StringBuilder stringBuilder = new StringBuilder("");
			while (enumerator.MoveNext())
			{
				string key = enumerator.Current.Key;
				string value = enumerator.Current.Value;
				if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
				{
					stringBuilder.Append(key).Append("=").Append(value)
						.Append("&");
				}
			}
			return stringBuilder.ToString().Substring(0, stringBuilder.Length - 1);
		}

		public static string RSASign(IDictionary<string, string> parameters, string privateKeyPem, string charset, string signType)
		{
			string signContent = GetSignContent(parameters);
			return RSASignCharSet(signContent, privateKeyPem, charset, signType);
		}

		public static string RSASign(string data, string privateKeyPem, string charset, string signType)
		{
			return RSASignCharSet(data, privateKeyPem, charset, signType);
		}

		public static string RSASign(IDictionary<string, string> parameters, string privateKeyPem, string charset, bool keyFromFile, string signType)
		{
			string signContent = GetSignContent(parameters);
			return RSASignCharSet(signContent, privateKeyPem, charset, keyFromFile, signType);
		}

		public static string RSASign(string data, string privateKeyPem, string charset, string signType, bool keyFromFile)
		{
			return RSASignCharSet(data, privateKeyPem, charset, keyFromFile, signType);
		}

		public static string RSASignCharSet(string data, string privateKeyPem, string charset, string signType)
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = LoadCertificateFile(privateKeyPem, signType);
			byte[] array = null;
			array = ((!string.IsNullOrEmpty(charset)) ? Encoding.GetEncoding(charset).GetBytes(data) : Encoding.UTF8.GetBytes(data));
			if ("RSA2".Equals(signType))
			{
				byte[] inArray = rSACryptoServiceProvider.SignData(array, "SHA256");
				return Convert.ToBase64String(inArray);
			}
			byte[] inArray2 = rSACryptoServiceProvider.SignData(array, "SHA1");
			return Convert.ToBase64String(inArray2);
		}

		public static string RSASignCharSet(string data, string privateKeyPem, string charset, bool keyFromFile, string signType)
		{
			byte[] array = null;
			try
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = null;
				rSACryptoServiceProvider = ((!keyFromFile) ? LoadCertificateString(privateKeyPem, signType) : LoadCertificateFile(privateKeyPem, signType));
				byte[] array2 = null;
				array2 = ((!string.IsNullOrEmpty(charset)) ? Encoding.GetEncoding(charset).GetBytes(data) : Encoding.UTF8.GetBytes(data));
				if (rSACryptoServiceProvider == null)
				{
					throw new AopException("您使用的私钥格式错误，请检查RSA私钥配置,charset = " + charset);
				}
				array = ((!"RSA2".Equals(signType)) ? rSACryptoServiceProvider.SignData(array2, "SHA1") : rSACryptoServiceProvider.SignData(array2, "SHA256"));
			}
			catch (Exception)
			{
				throw new AopException("您使用的私钥格式错误，请检查RSA私钥配置,charset = " + charset);
			}
			return Convert.ToBase64String(array);
		}

		public static bool RSACheckV1(IDictionary<string, string> parameters, string publicKeyPem, string charset)
		{
			string sign = parameters["sign"];
			parameters.Remove("sign");
			parameters.Remove("sign_type");
			string signContent = GetSignContent(parameters);
			return RSACheckContent(signContent, sign, publicKeyPem, charset, "RSA");
		}

		public static bool RSACheckV1(IDictionary<string, string> parameters, string publicKeyPem)
		{
			string sign = parameters["sign"];
			parameters.Remove("sign");
			parameters.Remove("sign_type");
			string signContent = GetSignContent(parameters);
			return RSACheckContent(signContent, sign, publicKeyPem, DEFAULT_CHARSET, "RSA");
		}

		public static bool RSACheckV1(IDictionary<string, string> parameters, string publicKeyPem, string charset, string signType, bool keyFromFile)
		{
			string sign = parameters["sign"];
			parameters.Remove("sign");
			parameters.Remove("sign_type");
			string signContent = GetSignContent(parameters);
			return RSACheckContent(signContent, sign, publicKeyPem, charset, signType, keyFromFile);
		}

		public static bool RSACheckV2(IDictionary<string, string> parameters, string publicKeyPem)
		{
			string sign = parameters["sign"];
			parameters.Remove("sign");
			string signContent = GetSignContent(parameters);
			return RSACheckContent(signContent, sign, publicKeyPem, DEFAULT_CHARSET, "RSA");
		}

		public static bool RSACheckV2(IDictionary<string, string> parameters, string publicKeyPem, string charset)
		{
			string sign = parameters["sign"];
			parameters.Remove("sign");
			string signContent = GetSignContent(parameters);
			return RSACheckContent(signContent, sign, publicKeyPem, charset, "RSA");
		}

		public static bool RSACheckV2(IDictionary<string, string> parameters, string publicKeyPem, string charset, string signType, bool keyFromFile)
		{
			string sign = parameters["sign"];
			parameters.Remove("sign");
			string signContent = GetSignContent(parameters);
			return RSACheckContent(signContent, sign, publicKeyPem, charset, signType, keyFromFile);
		}

		public static bool RSACheckContent(string signContent, string sign, string publicKeyPem, string charset, string signType)
		{
			try
			{
				if (string.IsNullOrEmpty(charset))
				{
					charset = DEFAULT_CHARSET;
				}
				if ("RSA2".Equals(signType))
				{
					string sPEM = File.ReadAllText(publicKeyPem);
					RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
					rSACryptoServiceProvider.PersistKeyInCsp = false;
					RSACryptoServiceProviderExtension.LoadPublicKeyPEM(rSACryptoServiceProvider, sPEM);
					return rSACryptoServiceProvider.VerifyData(Encoding.GetEncoding(charset).GetBytes(signContent), "SHA256", Convert.FromBase64String(sign));
				}
				string sPEM2 = File.ReadAllText(publicKeyPem);
				RSACryptoServiceProvider rSACryptoServiceProvider2 = new RSACryptoServiceProvider();
				rSACryptoServiceProvider2.PersistKeyInCsp = false;
				RSACryptoServiceProviderExtension.LoadPublicKeyPEM(rSACryptoServiceProvider2, sPEM2);
				SHA1CryptoServiceProvider halg = new SHA1CryptoServiceProvider();
				return rSACryptoServiceProvider2.VerifyData(Encoding.GetEncoding(charset).GetBytes(signContent), halg, Convert.FromBase64String(sign));
			}
			catch
			{
				return false;
			}
		}

		public static bool RSACheckContent(string signContent, string sign, string publicKeyPem, string charset, string signType, bool keyFromFile)
		{
			try
			{
				if (string.IsNullOrEmpty(charset))
				{
					charset = DEFAULT_CHARSET;
				}
				string sPEM;
				if (keyFromFile)
				{
					sPEM = File.ReadAllText(publicKeyPem);
				}
				else
				{
					sPEM = "-----BEGIN PUBLIC KEY-----\r\n";
					sPEM += publicKeyPem;
					sPEM += "-----END PUBLIC KEY-----\r\n\r\n";
				}
				if ("RSA2".Equals(signType))
				{
					RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
					rSACryptoServiceProvider.PersistKeyInCsp = false;
					RSACryptoServiceProviderExtension.LoadPublicKeyPEM(rSACryptoServiceProvider, sPEM);
					return rSACryptoServiceProvider.VerifyData(Encoding.GetEncoding(charset).GetBytes(signContent), "SHA256", Convert.FromBase64String(sign));
				}
				RSACryptoServiceProvider rSACryptoServiceProvider2 = new RSACryptoServiceProvider();
				rSACryptoServiceProvider2.PersistKeyInCsp = false;
				RSACryptoServiceProviderExtension.LoadPublicKeyPEM(rSACryptoServiceProvider2, sPEM);
				SHA1CryptoServiceProvider halg = new SHA1CryptoServiceProvider();
				return rSACryptoServiceProvider2.VerifyData(Encoding.GetEncoding(charset).GetBytes(signContent), halg, Convert.FromBase64String(sign));
			}
			catch
			{
				return false;
			}
		}

		public static bool RSACheckContent(string signContent, string sign, string publicKeyPem, string charset, bool keyFromFile)
		{
			try
			{
				string sPEM;
				if (keyFromFile)
				{
					sPEM = File.ReadAllText(publicKeyPem);
				}
				else
				{
					sPEM = "-----BEGIN PUBLIC KEY-----\r\n";
					sPEM += publicKeyPem;
					sPEM += "-----END PUBLIC KEY-----\r\n\r\n";
				}
				RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
				rSACryptoServiceProvider.PersistKeyInCsp = false;
				RSACryptoServiceProviderExtension.LoadPublicKeyPEM(rSACryptoServiceProvider, sPEM);
				SHA1CryptoServiceProvider halg = new SHA1CryptoServiceProvider();
				if (string.IsNullOrEmpty(charset))
				{
					charset = DEFAULT_CHARSET;
				}
				return rSACryptoServiceProvider.VerifyData(Encoding.GetEncoding(charset).GetBytes(signContent), halg, Convert.FromBase64String(sign));
			}
			catch (Exception ex)
			{
				string text = ex.Message.ToString();
				return false;
			}
		}

		public static string CheckSignAndDecrypt(IDictionary<string, string> parameters, string alipayPublicKey, string cusPrivateKey, bool isCheckSign, bool isDecrypt)
		{
			string charset = parameters["charset"];
			string text = parameters["biz_content"];
			if (isCheckSign && !RSACheckV2(parameters, alipayPublicKey, charset))
			{
				throw new AopException("rsaCheck failure:rsaParams=" + parameters);
			}
			if (isDecrypt)
			{
				return RSADecrypt(text, cusPrivateKey, charset, "RSA");
			}
			return text;
		}

		public static string CheckSignAndDecrypt(IDictionary<string, string> parameters, string alipayPublicKey, string cusPrivateKey, bool isCheckSign, bool isDecrypt, string signType, bool keyFromFile)
		{
			string charset = parameters["charset"];
			string text = parameters["biz_content"];
			if (isCheckSign && !RSACheckV2(parameters, alipayPublicKey, charset, signType, keyFromFile))
			{
				throw new AopException("rsaCheck failure:rsaParams=" + parameters);
			}
			if (isDecrypt)
			{
				return RSADecrypt(text, cusPrivateKey, charset, signType, keyFromFile);
			}
			return text;
		}

		public static string encryptAndSign(string bizContent, string alipayPublicKey, string cusPrivateKey, string charset, bool isEncrypt, bool isSign, string signType, bool keyFromFile)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (string.IsNullOrEmpty(charset))
			{
				charset = DEFAULT_CHARSET;
			}
			stringBuilder.Append("<?xml version=\"1.0\" encoding=\"" + charset + "\"?>");
			if (isEncrypt)
			{
				stringBuilder.Append("<alipay>");
				string text = RSAEncrypt(bizContent, alipayPublicKey, charset, keyFromFile);
				stringBuilder.Append("<response>" + text + "</response>");
				stringBuilder.Append("<encryption_type>" + signType + "</encryption_type>");
				if (isSign)
				{
					string str = RSASign(text, cusPrivateKey, charset, signType, keyFromFile);
					stringBuilder.Append("<sign>" + str + "</sign>");
					stringBuilder.Append("<sign_type>" + signType + "</sign_type>");
				}
				stringBuilder.Append("</alipay>");
			}
			else if (isSign)
			{
				stringBuilder.Append("<alipay>");
				stringBuilder.Append("<response>" + bizContent + "</response>");
				string str2 = RSASign(bizContent, cusPrivateKey, charset, signType, keyFromFile);
				stringBuilder.Append("<sign>" + str2 + "</sign>");
				stringBuilder.Append("<sign_type>" + signType + "</sign_type>");
				stringBuilder.Append("</alipay>");
			}
			else
			{
				stringBuilder.Append(bizContent);
			}
			return stringBuilder.ToString();
		}

		public static string encryptAndSign(string bizContent, string alipayPublicKey, string cusPrivateKey, string charset, bool isEncrypt, bool isSign)
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (string.IsNullOrEmpty(charset))
			{
				charset = DEFAULT_CHARSET;
			}
			stringBuilder.Append("<?xml version=\"1.0\" encoding=\"" + charset + "\"?>");
			if (isEncrypt)
			{
				stringBuilder.Append("<alipay>");
				string text = RSAEncrypt(bizContent, alipayPublicKey, charset);
				stringBuilder.Append("<response>" + text + "</response>");
				stringBuilder.Append("<encryption_type>RSA</encryption_type>");
				if (isSign)
				{
					string str = RSASign(text, cusPrivateKey, charset, "RSA");
					stringBuilder.Append("<sign>" + str + "</sign>");
					stringBuilder.Append("<sign_type>RSA</sign_type>");
				}
				stringBuilder.Append("</alipay>");
			}
			else if (isSign)
			{
				stringBuilder.Append("<alipay>");
				stringBuilder.Append("<response>" + bizContent + "</response>");
				string str2 = RSASign(bizContent, cusPrivateKey, charset, "RSA");
				stringBuilder.Append("<sign>" + str2 + "</sign>");
				stringBuilder.Append("<sign_type>RSA</sign_type>");
				stringBuilder.Append("</alipay>");
			}
			else
			{
				stringBuilder.Append(bizContent);
			}
			return stringBuilder.ToString();
		}

		public static string RSAEncrypt(string content, string publicKeyPem, string charset)
		{
			try
			{
				string sPEM = File.ReadAllText(publicKeyPem);
				RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
				rSACryptoServiceProvider.PersistKeyInCsp = false;
				RSACryptoServiceProviderExtension.LoadPublicKeyPEM(rSACryptoServiceProvider, sPEM);
				if (string.IsNullOrEmpty(charset))
				{
					charset = DEFAULT_CHARSET;
				}
				byte[] bytes = Encoding.GetEncoding(charset).GetBytes(content);
				int num = rSACryptoServiceProvider.KeySize / 8 - 11;
				if (bytes.Length <= num)
				{
					byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false);
					return Convert.ToBase64String(inArray);
				}
				MemoryStream memoryStream = new MemoryStream(bytes);
				MemoryStream memoryStream2 = new MemoryStream();
				byte[] array = new byte[num];
				for (int num2 = memoryStream.Read(array, 0, num); num2 > 0; num2 = memoryStream.Read(array, 0, num))
				{
					byte[] array2 = new byte[num2];
					Array.Copy(array, 0, array2, 0, num2);
					byte[] array3 = rSACryptoServiceProvider.Encrypt(array2, fOAEP: false);
					memoryStream2.Write(array3, 0, array3.Length);
				}
				return Convert.ToBase64String(memoryStream2.ToArray(), Base64FormattingOptions.None);
			}
			catch (Exception innerException)
			{
				throw new AopException("EncryptContent = " + content + ",charset = " + charset, innerException);
			}
		}

		public static string RSAEncrypt(string content, string publicKeyPem, string charset, bool keyFromFile)
		{
			try
			{
				string sPEM;
				if (keyFromFile)
				{
					sPEM = File.ReadAllText(publicKeyPem);
				}
				else
				{
					sPEM = "-----BEGIN PUBLIC KEY-----\r\n";
					sPEM += publicKeyPem;
					sPEM += "-----END PUBLIC KEY-----\r\n\r\n";
				}
				RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
				rSACryptoServiceProvider.PersistKeyInCsp = false;
				RSACryptoServiceProviderExtension.LoadPublicKeyPEM(rSACryptoServiceProvider, sPEM);
				if (string.IsNullOrEmpty(charset))
				{
					charset = DEFAULT_CHARSET;
				}
				byte[] bytes = Encoding.GetEncoding(charset).GetBytes(content);
				int num = rSACryptoServiceProvider.KeySize / 8 - 11;
				if (bytes.Length <= num)
				{
					byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false);
					return Convert.ToBase64String(inArray);
				}
				MemoryStream memoryStream = new MemoryStream(bytes);
				MemoryStream memoryStream2 = new MemoryStream();
				byte[] array = new byte[num];
				for (int num2 = memoryStream.Read(array, 0, num); num2 > 0; num2 = memoryStream.Read(array, 0, num))
				{
					byte[] array2 = new byte[num2];
					Array.Copy(array, 0, array2, 0, num2);
					byte[] array3 = rSACryptoServiceProvider.Encrypt(array2, fOAEP: false);
					memoryStream2.Write(array3, 0, array3.Length);
				}
				return Convert.ToBase64String(memoryStream2.ToArray(), Base64FormattingOptions.None);
			}
			catch (Exception innerException)
			{
				throw new AopException("EncryptContent = " + content + ",charset = " + charset, innerException);
			}
		}

		public static string RSADecrypt(string content, string privateKeyPem, string charset, string signType)
		{
			try
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = LoadCertificateFile(privateKeyPem, signType);
				if (string.IsNullOrEmpty(charset))
				{
					charset = DEFAULT_CHARSET;
				}
				byte[] array = Convert.FromBase64String(content);
				int num = rSACryptoServiceProvider.KeySize / 8;
				if (array.Length <= num)
				{
					byte[] bytes = rSACryptoServiceProvider.Decrypt(array, fOAEP: false);
					return Encoding.GetEncoding(charset).GetString(bytes);
				}
				MemoryStream memoryStream = new MemoryStream(array);
				MemoryStream memoryStream2 = new MemoryStream();
				byte[] array2 = new byte[num];
				for (int num2 = memoryStream.Read(array2, 0, num); num2 > 0; num2 = memoryStream.Read(array2, 0, num))
				{
					byte[] array3 = new byte[num2];
					Array.Copy(array2, 0, array3, 0, num2);
					byte[] array4 = rSACryptoServiceProvider.Decrypt(array3, fOAEP: false);
					memoryStream2.Write(array4, 0, array4.Length);
				}
				return Encoding.GetEncoding(charset).GetString(memoryStream2.ToArray());
			}
			catch (Exception innerException)
			{
				throw new AopException("DecryptContent = " + content + ",charset = " + charset, innerException);
			}
		}

		public static string RSADecrypt(string content, string privateKeyPem, string charset, string signType, bool keyFromFile)
		{
			try
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = null;
				rSACryptoServiceProvider = ((!keyFromFile) ? LoadCertificateString(privateKeyPem, signType) : LoadCertificateFile(privateKeyPem, signType));
				if (string.IsNullOrEmpty(charset))
				{
					charset = DEFAULT_CHARSET;
				}
				byte[] array = Convert.FromBase64String(content);
				int num = rSACryptoServiceProvider.KeySize / 8;
				if (array.Length <= num)
				{
					byte[] bytes = rSACryptoServiceProvider.Decrypt(array, fOAEP: false);
					return Encoding.GetEncoding(charset).GetString(bytes);
				}
				MemoryStream memoryStream = new MemoryStream(array);
				MemoryStream memoryStream2 = new MemoryStream();
				byte[] array2 = new byte[num];
				for (int num2 = memoryStream.Read(array2, 0, num); num2 > 0; num2 = memoryStream.Read(array2, 0, num))
				{
					byte[] array3 = new byte[num2];
					Array.Copy(array2, 0, array3, 0, num2);
					byte[] array4 = rSACryptoServiceProvider.Decrypt(array3, fOAEP: false);
					memoryStream2.Write(array4, 0, array4.Length);
				}
				return Encoding.GetEncoding(charset).GetString(memoryStream2.ToArray());
			}
			catch (Exception innerException)
			{
				throw new AopException("DecryptContent = " + content + ",charset = " + charset, innerException);
			}
		}

		private static byte[] GetPem(string type, byte[] data)
		{
			string @string = Encoding.UTF8.GetString(data);
			string text = $"-----BEGIN {type}-----\\n";
			string value = $"-----END {type}-----";
			int num = @string.IndexOf(text) + text.Length;
			int num2 = @string.IndexOf(value, num);
			string s = @string.Substring(num, num2 - num);
			return Convert.FromBase64String(s);
		}

		private static RSACryptoServiceProvider LoadCertificateFile(string filename, string signType)
		{
			using (FileStream fileStream = File.OpenRead(filename))
			{
				byte[] array = new byte[fileStream.Length];
				byte[] privkey = null;
				fileStream.Read(array, 0, array.Length);
				if (array[0] != 48)
				{
					privkey = GetPem("RSA PRIVATE KEY", array);
				}
				try
				{
					return DecodeRSAPrivateKey(privkey, signType);
				}
				catch (Exception)
				{
				}
				return null;
			}
		}

		private static RSACryptoServiceProvider LoadCertificateString(string strKey, string signType)
		{
			byte[] array = null;
			array = Convert.FromBase64String(strKey);
			try
			{
				return DecodeRSAPrivateKey(array, signType);
			}
			catch (Exception)
			{
			}
			return null;
		}

		private static RSACryptoServiceProvider DecodeRSAPrivateKey(byte[] privkey, string signType)
		{
			MemoryStream input = new MemoryStream(privkey);
			BinaryReader binaryReader = new BinaryReader(input);
			byte b = 0;
			ushort num = 0;
			int num2 = 0;
			try
			{
				switch (binaryReader.ReadUInt16())
				{
				case 33072:
					binaryReader.ReadByte();
					break;
				case 33328:
					binaryReader.ReadInt16();
					break;
				default:
					return null;
				}
				num = binaryReader.ReadUInt16();
				if (num != 258)
				{
					return null;
				}
				if (binaryReader.ReadByte() != 0)
				{
					return null;
				}
				num2 = GetIntegerSize(binaryReader);
				byte[] modulus = binaryReader.ReadBytes(num2);
				num2 = GetIntegerSize(binaryReader);
				byte[] exponent = binaryReader.ReadBytes(num2);
				num2 = GetIntegerSize(binaryReader);
				byte[] d = binaryReader.ReadBytes(num2);
				num2 = GetIntegerSize(binaryReader);
				byte[] p = binaryReader.ReadBytes(num2);
				num2 = GetIntegerSize(binaryReader);
				byte[] q = binaryReader.ReadBytes(num2);
				num2 = GetIntegerSize(binaryReader);
				byte[] dP = binaryReader.ReadBytes(num2);
				num2 = GetIntegerSize(binaryReader);
				byte[] dQ = binaryReader.ReadBytes(num2);
				num2 = GetIntegerSize(binaryReader);
				byte[] inverseQ = binaryReader.ReadBytes(num2);
				CspParameters cspParameters = new CspParameters();
				cspParameters.Flags = CspProviderFlags.UseMachineKeyStore;
				int dwKeySize = 1024;
				if ("RSA2".Equals(signType))
				{
					dwKeySize = 2048;
				}
				RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize, cspParameters);
				RSAParameters parameters = default(RSAParameters);
				parameters.Modulus = modulus;
				parameters.Exponent = exponent;
				parameters.D = d;
				parameters.P = p;
				parameters.Q = q;
				parameters.DP = dP;
				parameters.DQ = dQ;
				parameters.InverseQ = inverseQ;
				rSACryptoServiceProvider.ImportParameters(parameters);
				return rSACryptoServiceProvider;
			}
			catch (Exception)
			{
				return null;
			}
			finally
			{
				binaryReader.Close();
			}
		}

		private static int GetIntegerSize(BinaryReader binr)
		{
			byte b = 0;
			byte b2 = 0;
			byte b3 = 0;
			int num = 0;
			b = binr.ReadByte();
			if (b != 2)
			{
				return 0;
			}
			b = binr.ReadByte();
			switch (b)
			{
			case 129:
				num = binr.ReadByte();
				break;
			case 130:
			{
				b3 = binr.ReadByte();
				b2 = binr.ReadByte();
				byte[] value = new byte[4]
				{
					b2,
					b3,
					0,
					0
				};
				num = BitConverter.ToInt32(value, 0);
				break;
			}
			default:
				num = b;
				break;
			}
			while (binr.ReadByte() == 0)
			{
				num--;
			}
			binr.BaseStream.Seek(-1L, SeekOrigin.Current);
			return num;
		}
	}
}
