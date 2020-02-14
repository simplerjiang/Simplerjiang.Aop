using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAccountExrateAdviceAcceptResponse : AopResponse
	{
		[XmlElement("client_id")]
		public string ClientId
		{
			get;
			set;
		}

		[XmlElement("contra_amount")]
		public string ContraAmount
		{
			get;
			set;
		}

		[XmlElement("contra_ccy")]
		public string ContraCcy
		{
			get;
			set;
		}

		[XmlElement("deal_ref")]
		public string DealRef
		{
			get;
			set;
		}

		[XmlElement("dealt_rate")]
		public string DealtRate
		{
			get;
			set;
		}

		[XmlElement("duplicate")]
		public bool Duplicate
		{
			get;
			set;
		}

		[XmlElement("messag_id")]
		public string MessagId
		{
			get;
			set;
		}

		[XmlElement("msg_type")]
		public string MsgType
		{
			get;
			set;
		}

		[XmlElement("requested_rate_status")]
		public string RequestedRateStatus
		{
			get;
			set;
		}

		[XmlElement("side")]
		public string Side
		{
			get;
			set;
		}

		[XmlElement("transaction_amount")]
		public string TransactionAmount
		{
			get;
			set;
		}

		[XmlElement("transaction_ccy")]
		public string TransactionCcy
		{
			get;
			set;
		}

		[XmlElement("value_date")]
		public string ValueDate
		{
			get;
			set;
		}
	}
}
