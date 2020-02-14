using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AdviceVO : AopObject
	{
		[XmlElement("client_advice_timestamp")]
		public string ClientAdviceTimestamp
		{
			get;
			set;
		}

		[XmlElement("client_id")]
		public string ClientId
		{
			get;
			set;
		}

		[XmlElement("client_ref")]
		public string ClientRef
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

		[XmlElement("end_to_end_id")]
		public string EndToEndId
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

		[XmlElement("partial_trade")]
		public string PartialTrade
		{
			get;
			set;
		}

		[XmlElement("payment_provider")]
		public string PaymentProvider
		{
			get;
			set;
		}

		[XmlElement("payment_type")]
		public string PaymentType
		{
			get;
			set;
		}

		[XmlElement("profile_id")]
		public string ProfileId
		{
			get;
			set;
		}

		[XmlElement("rate_ref")]
		public string RateRef
		{
			get;
			set;
		}

		[XmlElement("rate_request_mode")]
		public string RateRequestMode
		{
			get;
			set;
		}

		[XmlElement("rate_type")]
		public string RateType
		{
			get;
			set;
		}

		[XmlElement("reference_field1")]
		public string ReferenceField1
		{
			get;
			set;
		}

		[XmlElement("reference_field2")]
		public string ReferenceField2
		{
			get;
			set;
		}

		[XmlElement("reference_field3")]
		public string ReferenceField3
		{
			get;
			set;
		}

		[XmlElement("related_message_id")]
		public string RelatedMessageId
		{
			get;
			set;
		}

		[XmlElement("request_message_id")]
		public string RequestMessageId
		{
			get;
			set;
		}

		[XmlElement("requested_rate")]
		public string RequestedRate
		{
			get;
			set;
		}

		[XmlElement("settlement_amount")]
		public string SettlementAmount
		{
			get;
			set;
		}

		[XmlElement("settlement_ccy")]
		public string SettlementCcy
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

		[XmlElement("slip_point")]
		public long SlipPoint
		{
			get;
			set;
		}

		[XmlElement("source_event_code")]
		public string SourceEventCode
		{
			get;
			set;
		}

		[XmlElement("source_product_code")]
		public string SourceProductCode
		{
			get;
			set;
		}

		[XmlElement("time_zone")]
		public string TimeZone
		{
			get;
			set;
		}

		[XmlElement("trade_timestamp")]
		public string TradeTimestamp
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

		[XmlElement("transaction_ccy_type")]
		public string TransactionCcyType
		{
			get;
			set;
		}

		[XmlElement("transaction_type")]
		public string TransactionType
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
