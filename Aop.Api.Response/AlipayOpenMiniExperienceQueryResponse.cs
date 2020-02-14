using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniExperienceQueryResponse : AopResponse
	{
		[XmlElement("exp_qr_code_url")]
		public string ExpQrCodeUrl
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
