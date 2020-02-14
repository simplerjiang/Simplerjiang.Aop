using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdIfaaDevicepubkeyQueryResponse : AopResponse
	{
		[XmlElement("device_key_info")]
		public string DeviceKeyInfo
		{
			get;
			set;
		}
	}
}
