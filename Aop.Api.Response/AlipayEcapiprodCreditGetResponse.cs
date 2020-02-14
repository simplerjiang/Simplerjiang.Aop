using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcapiprodCreditGetResponse : AopResponse
	{
		[XmlElement("credit_result")]
		public CreditResult CreditResult
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}
