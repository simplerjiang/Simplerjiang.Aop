using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransCollectSinglemoneytokenCreateResponse : AopResponse
	{
		[XmlElement("ext_param")]
		public string ExtParam
		{
			get;
			set;
		}

		[XmlElement("qr_code")]
		public string QrCode
		{
			get;
			set;
		}

		[XmlElement("zhi_token")]
		public string ZhiToken
		{
			get;
			set;
		}
	}
}
