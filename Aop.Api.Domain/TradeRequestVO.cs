using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TradeRequestVO : AopObject
	{
		[XmlElement("acquirer")]
		public string Acquirer
		{
			get;
			set;
		}

		[XmlElement("acquirer_mem_id")]
		public string AcquirerMemId
		{
			get;
			set;
		}

		[XmlElement("aml_status")]
		public string AmlStatus
		{
			get;
			set;
		}

		[XmlElement("biz_ev_code")]
		public string BizEvCode
		{
			get;
			set;
		}

		[XmlElement("biz_pd_code")]
		public string BizPdCode
		{
			get;
			set;
		}

		[XmlElement("client_advice_timestamp")]
		public string ClientAdviceTimestamp
		{
			get;
			set;
		}

		[XmlElement("client_business_id")]
		public string ClientBusinessId
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

		[XmlElement("client_message_id")]
		public string ClientMessageId
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

		[XmlElement("client_system")]
		public string ClientSystem
		{
			get;
			set;
		}

		[XmlElement("cnl_ev_code")]
		public string CnlEvCode
		{
			get;
			set;
		}

		[XmlElement("cnl_no")]
		public string CnlNo
		{
			get;
			set;
		}

		[XmlElement("cnl_pd_code")]
		public string CnlPdCode
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

		[XmlElement("extension")]
		public string Extension
		{
			get;
			set;
		}

		[XmlElement("inst_entity")]
		public string InstEntity
		{
			get;
			set;
		}

		[XmlElement("is_locked")]
		public string IsLocked
		{
			get;
			set;
		}

		[XmlElement("issuer")]
		public string Issuer
		{
			get;
			set;
		}

		[XmlElement("issuer_mem_id")]
		public string IssuerMemId
		{
			get;
			set;
		}

		[XmlElement("merchant_mcc")]
		public string MerchantMcc
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

		[XmlElement("operate_type")]
		public string OperateType
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

		[XmlElement("partner_id")]
		public string PartnerId
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

		[XmlElement("product_id")]
		public string ProductId
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

		[XmlElement("rate_base_ccy")]
		public string RateBaseCcy
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
		public string SlipPoint
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

		[XmlElement("tnt_inst_id")]
		public string TntInstId
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

		[XmlElement("trade_type")]
		public string TradeType
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

		[XmlElement("user_id")]
		public string UserId
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
