namespace Aop.Api.Util
{
	public class RSAUtil
	{
		public static string RSASign(string data, string privateKeyPem, string charset)
		{
			return AlipaySignature.RSASign(data, privateKeyPem, charset, "RSA");
		}
	}
}
