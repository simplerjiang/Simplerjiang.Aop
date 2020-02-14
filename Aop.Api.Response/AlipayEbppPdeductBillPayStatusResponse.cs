using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppPdeductBillPayStatusResponse : AopResponse
	{
		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("order_result_code")]
		public string OrderResultCode
		{
			get;
			set;
		}

		[XmlElement("order_result_msg")]
		public string OrderResultMsg
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
