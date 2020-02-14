using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Aop.Api.Util
{
	public static class RSACryptoServiceProviderExtension
	{
		internal enum CRYPT_ACQUIRE_CONTEXT_FLAGS : uint
		{
			CRYPT_NEWKEYSET = 8u,
			CRYPT_DELETEKEYSET = 0x10,
			CRYPT_MACHINE_KEYSET = 0x20,
			CRYPT_SILENT = 0x40,
			CRYPT_DEFAULT_CONTAINER_OPTIONAL = 0x80,
			CRYPT_VERIFYCONTEXT = 4026531840u
		}

		internal enum CRYPT_PROVIDER_TYPE : uint
		{
			PROV_RSA_FULL = 1u
		}

		internal enum CRYPT_DECODE_FLAGS : uint
		{
			NONE = 0u,
			CRYPT_DECODE_ALLOC_FLAG = 0x8000
		}

		internal enum CRYPT_ENCODING_FLAGS : uint
		{
			PKCS_7_ASN_ENCODING = 0x10000,
			X509_ASN_ENCODING = 1u
		}

		internal enum CRYPT_OUTPUT_TYPES
		{
			X509_PUBLIC_KEY_INFO = 8,
			RSA_CSP_PUBLICKEYBLOB = 19,
			PKCS_RSA_PRIVATE_KEY = 43,
			PKCS_PRIVATE_KEY_INFO = 44
		}

		internal enum CRYPT_STRING_FLAGS : uint
		{
			CRYPT_STRING_BASE64HEADER = 0u,
			CRYPT_STRING_BASE64 = 1u,
			CRYPT_STRING_BINARY = 2u,
			CRYPT_STRING_BASE64REQUESTHEADER = 3u,
			CRYPT_STRING_HEX = 4u,
			CRYPT_STRING_HEXASCII = 5u,
			CRYPT_STRING_BASE64_ANY = 6u,
			CRYPT_STRING_ANY = 7u,
			CRYPT_STRING_HEX_ANY = 8u,
			CRYPT_STRING_BASE64X509CRLHEADER = 9u,
			CRYPT_STRING_HEXADDR = 10u,
			CRYPT_STRING_HEXASCIIADDR = 11u,
			CRYPT_STRING_HEXRAW = 12u,
			CRYPT_STRING_NOCRLF = 0x40000000,
			CRYPT_STRING_NOCR = 0x80000000
		}

		internal struct CRYPT_OBJID_BLOB
		{
			internal uint cbData;

			internal IntPtr pbData;
		}

		internal struct CRYPT_ALGORITHM_IDENTIFIER
		{
			internal IntPtr pszObjId;

			internal CRYPT_OBJID_BLOB Parameters;
		}

		private struct CRYPT_BIT_BLOB
		{
			internal uint cbData;

			internal IntPtr pbData;

			internal uint cUnusedBits;
		}

		private struct CERT_PUBLIC_KEY_INFO
		{
			internal CRYPT_ALGORITHM_IDENTIFIER Algorithm;

			internal CRYPT_BIT_BLOB PublicKey;
		}

		public static void LoadPublicKeyDER(RSACryptoServiceProvider provider, byte[] DERData)
		{
			byte[] rSAFromDER = GetRSAFromDER(DERData);
			byte[] publicKeyBlobFromRSA = GetPublicKeyBlobFromRSA(rSAFromDER);
			provider.ImportCspBlob(publicKeyBlobFromRSA);
		}

		public static void LoadPublicKeyPEM(RSACryptoServiceProvider provider, string sPEM)
		{
			byte[] dERFromPEM = GetDERFromPEM(sPEM);
			LoadPublicKeyDER(provider, dERFromPEM);
		}

		internal static byte[] GetPublicKeyBlobFromRSA(byte[] RSAData)
		{
			byte[] pvStructInfo = null;
			uint cbStructInfo = 0u;
			if (CryptDecodeObject((CRYPT_ENCODING_FLAGS)65537u, new IntPtr(19), RSAData, (uint)RSAData.Length, CRYPT_DECODE_FLAGS.NONE, pvStructInfo, ref cbStructInfo))
			{
				pvStructInfo = new byte[cbStructInfo];
				if (!CryptDecodeObject((CRYPT_ENCODING_FLAGS)65537u, new IntPtr(19), RSAData, (uint)RSAData.Length, CRYPT_DECODE_FLAGS.NONE, pvStructInfo, ref cbStructInfo))
				{
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
				return pvStructInfo;
			}
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}

		internal static byte[] GetRSAFromDER(byte[] DERData)
		{
			byte[] pvStructInfo = null;
			byte[] array = null;
			uint cbStructInfo = 0u;
			IntPtr zero = IntPtr.Zero;
			if (CryptDecodeObject((CRYPT_ENCODING_FLAGS)65537u, new IntPtr(8), DERData, (uint)DERData.Length, CRYPT_DECODE_FLAGS.NONE, pvStructInfo, ref cbStructInfo))
			{
				pvStructInfo = new byte[cbStructInfo];
				if (CryptDecodeObject((CRYPT_ENCODING_FLAGS)65537u, new IntPtr(8), DERData, (uint)DERData.Length, CRYPT_DECODE_FLAGS.NONE, pvStructInfo, ref cbStructInfo))
				{
					GCHandle gCHandle = GCHandle.Alloc(pvStructInfo, GCHandleType.Pinned);
					try
					{
						CERT_PUBLIC_KEY_INFO cERT_PUBLIC_KEY_INFO = (CERT_PUBLIC_KEY_INFO)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(CERT_PUBLIC_KEY_INFO));
						array = new byte[cERT_PUBLIC_KEY_INFO.PublicKey.cbData];
						Marshal.Copy(cERT_PUBLIC_KEY_INFO.PublicKey.pbData, array, 0, array.Length);
					}
					finally
					{
						gCHandle.Free();
					}
					return array;
				}
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}

		internal static byte[] GetDERFromPEM(string sPEM)
		{
			uint pcbBinary = 0u;
			if (!CryptStringToBinary(sPEM, (uint)sPEM.Length, CRYPT_STRING_FLAGS.CRYPT_STRING_BASE64HEADER, null, ref pcbBinary, out uint pdwSkip, out uint pdwFlags))
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			byte[] array = new byte[pcbBinary];
			if (!CryptStringToBinary(sPEM, (uint)sPEM.Length, CRYPT_STRING_FLAGS.CRYPT_STRING_BASE64HEADER, array, ref pcbBinary, out pdwSkip, out pdwFlags))
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			return array;
		}

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptDestroyKey(IntPtr hKey);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptImportKey(IntPtr hProv, byte[] pbKeyData, uint dwDataLen, IntPtr hPubKey, uint dwFlags, ref IntPtr hKey);

		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptReleaseContext(IntPtr hProv, int dwFlags);

		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptAcquireContext(ref IntPtr hProv, string pszContainer, string pszProvider, CRYPT_PROVIDER_TYPE dwProvType, CRYPT_ACQUIRE_CONTEXT_FLAGS dwFlags);

		[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptStringToBinary(string sPEM, uint sPEMLength, CRYPT_STRING_FLAGS dwFlags, [Out] byte[] pbBinary, ref uint pcbBinary, out uint pdwSkip, out uint pdwFlags);

		[DllImport("crypt32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptDecodeObjectEx(CRYPT_ENCODING_FLAGS dwCertEncodingType, IntPtr lpszStructType, byte[] pbEncoded, uint cbEncoded, CRYPT_DECODE_FLAGS dwFlags, IntPtr pDecodePara, ref byte[] pvStructInfo, ref uint pcbStructInfo);

		[DllImport("crypt32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptDecodeObject(CRYPT_ENCODING_FLAGS dwCertEncodingType, IntPtr lpszStructType, byte[] pbEncoded, uint cbEncoded, CRYPT_DECODE_FLAGS flags, [In] [Out] byte[] pvStructInfo, ref uint cbStructInfo);
	}
}
