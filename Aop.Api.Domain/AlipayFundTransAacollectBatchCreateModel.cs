using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundTransAacollectBatchCreateModel : AopObject
	{
		[XmlElement("batch_memo")]
		public string BatchMemo
		{
			get;
			set;
		}

		[XmlElement("channel")]
		public string Channel
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

		[XmlElement("limit_items_total")]
		public string LimitItemsTotal
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

		[XmlElement("payee_user_id")]
		public string PayeeUserId
		{
			get;
			set;
		}

		[XmlElement("payer_user_ids")]
		public string PayerUserIds
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

		[XmlElement("source")]
		public string Source
		{
			get;
			set;
		}
	}
}
