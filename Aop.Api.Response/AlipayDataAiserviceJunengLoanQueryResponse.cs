using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataAiserviceJunengLoanQueryResponse : AopResponse
	{
		[XmlElement("biz_error_code")]
		public string BizErrorCode
		{
			get;
			set;
		}

		[XmlElement("hashed_cert_no")]
		public string HashedCertNo
		{
			get;
			set;
		}

		[XmlElement("request_uuid")]
		public string RequestUuid
		{
			get;
			set;
		}

		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
