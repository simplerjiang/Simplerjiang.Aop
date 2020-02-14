using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserCharityForestsendpicSendResponse : AopResponse
	{
		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("result_desc")]
		public string ResultDesc
		{
			get;
			set;
		}

		[XmlElement("success")]
		public string Success
		{
			get;
			set;
		}
	}
}
