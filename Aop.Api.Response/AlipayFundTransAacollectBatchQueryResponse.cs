using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransAacollectBatchQueryResponse : AopResponse
	{
		[XmlElement("batch_memo")]
		public string BatchMemo
		{
			get;
			set;
		}

		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("batch_status")]
		public string BatchStatus
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

		[XmlElement("create_date")]
		public string CreateDate
		{
			get;
			set;
		}

		[XmlElement("creater_user_id")]
		public string CreaterUserId
		{
			get;
			set;
		}

		[XmlArray("detail_list")]
		[XmlArrayItem("batch_detail_info")]
		public List<BatchDetailInfo> DetailList
		{
			get;
			set;
		}

		[XmlElement("ext_param")]
		public string ExtParam
		{
			get;
			set;
		}

		[XmlArray("paid_detail_list")]
		[XmlArrayItem("batch_detail_info")]
		public List<BatchDetailInfo> PaidDetailList
		{
			get;
			set;
		}

		[XmlElement("pay_amount_single")]
		public string PayAmountSingle
		{
			get;
			set;
		}

		[XmlElement("pay_amount_total")]
		public string PayAmountTotal
		{
			get;
			set;
		}

		[XmlElement("pay_amount_total_for_receiver")]
		public string PayAmountTotalForReceiver
		{
			get;
			set;
		}

		[XmlElement("real_items_total")]
		public string RealItemsTotal
		{
			get;
			set;
		}

		[XmlElement("show_items_total")]
		public string ShowItemsTotal
		{
			get;
			set;
		}

		[XmlElement("success_amount_total")]
		public string SuccessAmountTotal
		{
			get;
			set;
		}

		[XmlElement("time_out_value")]
		public string TimeOutValue
		{
			get;
			set;
		}

		[XmlArray("unpaid_detail_list")]
		[XmlArrayItem("batch_detail_info")]
		public List<BatchDetailInfo> UnpaidDetailList
		{
			get;
			set;
		}
	}
}
