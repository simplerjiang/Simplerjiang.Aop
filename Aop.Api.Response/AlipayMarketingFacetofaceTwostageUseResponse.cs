using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingFacetofaceTwostageUseResponse : AopResponse
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("havana_id")]
		public string HavanaId
		{
			get;
			set;
		}

		[XmlElement("otp_verify")]
		public string OtpVerify
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
