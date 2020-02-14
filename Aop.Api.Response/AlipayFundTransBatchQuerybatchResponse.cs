using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransBatchQuerybatchResponse : AopResponse
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

		[XmlElement("batch_type")]
		public string BatchType
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

		[XmlElement("create_user_id")]
		public string CreateUserId
		{
			get;
			set;
		}

		[XmlElement("detail_list")]
		public QueryDetailAopResult DetailList
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

		[XmlElement("success_items_total")]
		public string SuccessItemsTotal
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

		[XmlElement("token")]
		public string Token
		{
			get;
			set;
		}
	}
}
