using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdFingerprintApplyResponse : AopResponse
	{
		[XmlElement("auth_type")]
		public string AuthType
		{
			get;
			set;
		}

		[XmlElement("device_id")]
		public string DeviceId
		{
			get;
			set;
		}

		[XmlElement("token")]
		public string Token
		{
			get;
			set;
		}
	}
}
