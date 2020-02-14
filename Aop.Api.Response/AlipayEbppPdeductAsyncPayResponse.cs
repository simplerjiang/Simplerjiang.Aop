using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppPdeductAsyncPayResponse : AopResponse
	{
		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("result_status")]
		public string ResultStatus
		{
			get;
			set;
		}
	}
}
