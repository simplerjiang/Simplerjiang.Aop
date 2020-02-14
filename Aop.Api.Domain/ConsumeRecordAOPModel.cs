using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ConsumeRecordAOPModel : AopObject
	{
		[XmlElement("access_channel")]
		public string AccessChannel
		{
			get;
			set;
		}

		[XmlElement("additional_status")]
		public string AdditionalStatus
		{
			get;
			set;
		}

		[XmlArray("biz_actions")]
		[XmlArrayItem("string")]
		public List<string> BizActions
		{
			get;
			set;
		}

		[XmlElement("biz_extra_no")]
		public string BizExtraNo
		{
			get;
			set;
		}

		[XmlElement("biz_in_no")]
		public string BizInNo
		{
			get;
			set;
		}

		[XmlElement("biz_memo")]
		public string BizMemo
		{
			get;
			set;
		}

		[XmlElement("biz_orig")]
		public string BizOrig
		{
			get;
			set;
		}

		[XmlElement("biz_out_no")]
		public string BizOutNo
		{
			get;
			set;
		}

		[XmlElement("biz_state")]
		public string BizState
		{
			get;
			set;
		}

		[XmlElement("biz_sub_type")]
		public string BizSubType
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("category_id")]
		public string CategoryId
		{
			get;
			set;
		}

		[XmlElement("consume_fee")]
		public string ConsumeFee
		{
			get;
			set;
		}

		[XmlElement("consume_refund_status")]
		public string ConsumeRefundStatus
		{
			get;
			set;
		}

		[XmlElement("consume_site")]
		public string ConsumeSite
		{
			get;
			set;
		}

		[XmlElement("consume_status")]
		public string ConsumeStatus
		{
			get;
			set;
		}

		[XmlElement("consume_title")]
		public string ConsumeTitle
		{
			get;
			set;
		}

		[XmlElement("consume_type")]
		public string ConsumeType
		{
			get;
			set;
		}

		[XmlElement("currency")]
		public string Currency
		{
			get;
			set;
		}

		[XmlElement("delete_over_time")]
		public string DeleteOverTime
		{
			get;
			set;
		}

		[XmlElement("delete_time")]
		public string DeleteTime
		{
			get;
			set;
		}

		[XmlElement("delete_type")]
		public string DeleteType
		{
			get;
			set;
		}

		[XmlElement("depositback_status")]
		public string DepositbackStatus
		{
			get;
			set;
		}

		[XmlElement("flag_locked")]
		public string FlagLocked
		{
			get;
			set;
		}

		[XmlElement("flag_refund")]
		public string FlagRefund
		{
			get;
			set;
		}

		[XmlElement("gmt_biz_create")]
		public string GmtBizCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_biz_modified")]
		public string GmtBizModified
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("gmt_receive_pay")]
		public string GmtReceivePay
		{
			get;
			set;
		}

		[XmlElement("gmt_send_pay")]
		public string GmtSendPay
		{
			get;
			set;
		}

		[XmlElement("has_fund_item")]
		public bool HasFundItem
		{
			get;
			set;
		}

		[XmlElement("has_new_fund_item")]
		public bool HasNewFundItem
		{
			get;
			set;
		}

		[XmlElement("in_out")]
		public string InOut
		{
			get;
			set;
		}

		[XmlElement("opposite_card_no")]
		public string OppositeCardNo
		{
			get;
			set;
		}

		[XmlElement("opposite_login_id")]
		public string OppositeLoginId
		{
			get;
			set;
		}

		[XmlElement("opposite_name")]
		public string OppositeName
		{
			get;
			set;
		}

		[XmlElement("opposite_nick_name")]
		public string OppositeNickName
		{
			get;
			set;
		}

		[XmlElement("orig_consume_title")]
		public string OrigConsumeTitle
		{
			get;
			set;
		}

		[XmlElement("owner_card_no")]
		public string OwnerCardNo
		{
			get;
			set;
		}

		[XmlElement("owner_customer_id")]
		public string OwnerCustomerId
		{
			get;
			set;
		}

		[XmlElement("owner_login_id")]
		public string OwnerLoginId
		{
			get;
			set;
		}

		[XmlElement("owner_name")]
		public string OwnerName
		{
			get;
			set;
		}

		[XmlElement("owner_nick")]
		public string OwnerNick
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

		[XmlElement("pay_channel")]
		public string PayChannel
		{
			get;
			set;
		}

		[XmlElement("peerpayer_real_name")]
		public string PeerpayerRealName
		{
			get;
			set;
		}

		[XmlElement("product")]
		public string Product
		{
			get;
			set;
		}

		[XmlElement("refund_fee")]
		public string RefundFee
		{
			get;
			set;
		}

		[XmlElement("service_fee")]
		public string ServiceFee
		{
			get;
			set;
		}

		[XmlElement("total_refund_fee")]
		public string TotalRefundFee
		{
			get;
			set;
		}

		[XmlElement("trade_from")]
		public string TradeFrom
		{
			get;
			set;
		}
	}
}
