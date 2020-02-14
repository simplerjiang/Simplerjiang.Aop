using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BatchFundItemAOPModel : AopObject
	{
		[XmlElement("batch_no")]
		public long BatchNo
		{
			get;
			set;
		}

		[XmlElement("dback_refundtobank_processing_batch_amount")]
		public string DbackRefundtobankProcessingBatchAmount
		{
			get;
			set;
		}

		[XmlElement("dback_refundtobank_success_batch_amount")]
		public string DbackRefundtobankSuccessBatchAmount
		{
			get;
			set;
		}

		[XmlArray("fund_item_list")]
		[XmlArrayItem("fund_item_a_o_p_model")]
		public List<FundItemAOPModel> FundItemList
		{
			get;
			set;
		}

		[XmlElement("gmt_biz_create_date")]
		public string GmtBizCreateDate
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}

		[XmlElement("total_amount_with_service_fee")]
		public string TotalAmountWithServiceFee
		{
			get;
			set;
		}
	}
}
