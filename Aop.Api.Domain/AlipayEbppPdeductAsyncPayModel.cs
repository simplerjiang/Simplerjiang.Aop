using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppPdeductAsyncPayModel : AopObject
	{
		[XmlElement("agent_channel")]
		public string AgentChannel
		{
			get;
			set;
		}

		[XmlElement("agent_code")]
		public string AgentCode
		{
			get;
			set;
		}

		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}

		[XmlElement("bill_date")]
		public string BillDate
		{
			get;
			set;
		}

		[XmlElement("bill_key")]
		public string BillKey
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

		[XmlElement("fine_amount")]
		public string FineAmount
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
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

		[XmlElement("pay_amount")]
		public string PayAmount
		{
			get;
			set;
		}

		[XmlElement("pid")]
		public string Pid
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
