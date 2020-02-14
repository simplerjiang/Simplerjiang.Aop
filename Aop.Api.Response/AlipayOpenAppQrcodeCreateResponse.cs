using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppQrcodeCreateResponse : AopResponse
	{
		[XmlElement("qr_code_url")]
		public string QrCodeUrl
		{
			get;
			set;
		}
	}
}
