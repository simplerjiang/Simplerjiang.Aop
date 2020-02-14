using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundTransBatchCreatesinglebatchModel : AopObject
	{
		[XmlElement("batch_memo")]
		public string BatchMemo
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

		[XmlElement("create_user_id")]
		public string CreateUserId
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
	}
}
