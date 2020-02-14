using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppPdeductPayResponse : AopResponse
	{
		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}

		[XmlElement("bill_no")]
		public string BillNo
		{
			get;
			set;
		}

		[XmlElement("extend_field")]
		public string ExtendField
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

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("result_msg")]
		public string ResultMsg
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
