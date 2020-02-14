using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FundItemAOPModel : AopObject
	{
		[XmlElement("acctrans_out_biz_no")]
		public string AcctransOutBizNo
		{
			get;
			set;
		}

		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("assert_type_code")]
		public string AssertTypeCode
		{
			get;
			set;
		}

		[XmlElement("bank_card_pay_type")]
		public string BankCardPayType
		{
			get;
			set;
		}

		[XmlElement("bank_card_type")]
		public string BankCardType
		{
			get;
			set;
		}

		[XmlElement("biz_id")]
		public string BizId
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

		[XmlElement("biz_out_no")]
		public string BizOutNo
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

		[XmlElement("currency")]
		public string Currency
		{
			get;
			set;
		}

		[XmlElement("dback_amount")]
		public string DbackAmount
		{
			get;
			set;
		}

		[XmlElement("dback_gmt_create")]
		public string DbackGmtCreate
		{
			get;
			set;
		}

		[XmlElement("dback_gmt_est_bk_ack")]
		public string DbackGmtEstBkAck
		{
			get;
			set;
		}

		[XmlElement("dback_gmt_est_bk_into")]
		public string DbackGmtEstBkInto
		{
			get;
			set;
		}

		[XmlElement("dback_inst_account_name")]
		public string DbackInstAccountName
		{
			get;
			set;
		}

		[XmlElement("dback_inst_account_no")]
		public string DbackInstAccountNo
		{
			get;
			set;
		}

		[XmlElement("dback_inst_id")]
		public string DbackInstId
		{
			get;
			set;
		}

		[XmlElement("dback_inst_name")]
		public string DbackInstName
		{
			get;
			set;
		}

		[XmlElement("fid")]
		public string Fid
		{
			get;
			set;
		}

		[XmlElement("fund_access_type")]
		public long FundAccessType
		{
			get;
			set;
		}

		[XmlElement("fund_account_no")]
		public string FundAccountNo
		{
			get;
			set;
		}

		[XmlElement("fund_biz_type")]
		public long FundBizType
		{
			get;
			set;
		}

		[XmlElement("fund_create_time")]
		public string FundCreateTime
		{
			get;
			set;
		}

		[XmlElement("fund_finish_time")]
		public string FundFinishTime
		{
			get;
			set;
		}

		[XmlElement("fund_in_out")]
		public long FundInOut
		{
			get;
			set;
		}

		[XmlElement("fund_inst_id")]
		public string FundInstId
		{
			get;
			set;
		}

		[XmlElement("fund_modify_time")]
		public string FundModifyTime
		{
			get;
			set;
		}

		[XmlElement("fund_status")]
		public string FundStatus
		{
			get;
			set;
		}

		[XmlElement("fund_tool_belong_to_crowner")]
		public bool FundToolBelongToCrowner
		{
			get;
			set;
		}

		[XmlElement("fund_tool_owner_card_no")]
		public string FundToolOwnerCardNo
		{
			get;
			set;
		}

		[XmlElement("fund_tool_type_for_crowner")]
		public string FundToolTypeForCrowner
		{
			get;
			set;
		}

		[XmlElement("fund_tool_type_for_system")]
		public string FundToolTypeForSystem
		{
			get;
			set;
		}

		[XmlElement("fund_tool_type_name")]
		public string FundToolTypeName
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

		[XmlElement("open_self_slip_type")]
		public string OpenSelfSlipType
		{
			get;
			set;
		}

		[XmlElement("opposite_biz_card_alias")]
		public string OppositeBizCardAlias
		{
			get;
			set;
		}

		[XmlElement("opposite_biz_card_no")]
		public string OppositeBizCardNo
		{
			get;
			set;
		}

		[XmlElement("opposite_fund_card_no")]
		public string OppositeFundCardNo
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
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

		[XmlElement("refund_bank_status")]
		public string RefundBankStatus
		{
			get;
			set;
		}

		[XmlElement("slip_amount")]
		public string SlipAmount
		{
			get;
			set;
		}

		[XmlElement("slip_id")]
		public string SlipId
		{
			get;
			set;
		}

		[XmlElement("slip_status")]
		public string SlipStatus
		{
			get;
			set;
		}

		[XmlElement("sub_prepaid_card_type")]
		public string SubPrepaidCardType
		{
			get;
			set;
		}

		[XmlElement("uid")]
		public string Uid
		{
			get;
			set;
		}
	}
}
