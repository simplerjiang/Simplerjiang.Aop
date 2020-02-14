using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BatchRefundDetailResult : AopObject
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("dback_status")]
		public string DbackStatus
		{
			get;
			set;
		}

		[XmlElement("est_bank_ack_time")]
		public string EstBankAckTime
		{
			get;
			set;
		}

		[XmlElement("est_bank_receipt_time")]
		public string EstBankReceiptTime
		{
			get;
			set;
		}

		[XmlElement("has_deposit_back")]
		public bool HasDepositBack
		{
			get;
			set;
		}

		[XmlElement("refund_amount")]
		public string RefundAmount
		{
			get;
			set;
		}

		[XmlArray("refund_royaltys")]
		[XmlArrayItem("refund_royalty_result")]
		public List<RefundRoyaltyResult> RefundRoyaltys
		{
			get;
			set;
		}

		[XmlElement("refund_suppl_amount")]
		public string RefundSupplAmount
		{
			get;
			set;
		}

		[XmlElement("refund_suppl_result_code")]
		public string RefundSupplResultCode
		{
			get;
			set;
		}

		[XmlElement("rest_suppl_amount")]
		public string RestSupplAmount
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

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}

		[XmlElement("unfreeze_details")]
		public RefundUnfreezeResult UnfreezeDetails
		{
			get;
			set;
		}
	}
}
