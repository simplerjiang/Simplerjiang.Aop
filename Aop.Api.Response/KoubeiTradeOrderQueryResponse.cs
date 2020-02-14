using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiTradeOrderQueryResponse : AopResponse
	{
		[XmlArray("activity_infos")]
		[XmlArrayItem("kb_order_activity_model")]
		public List<KbOrderActivityModel> ActivityInfos
		{
			get;
			set;
		}

		[XmlElement("buyer_id")]
		public string BuyerId
		{
			get;
			set;
		}

		[XmlElement("contact")]
		public string Contact
		{
			get;
			set;
		}

		[XmlArray("funds_vouchers")]
		[XmlArrayItem("kb_order_funds_voucher_model")]
		public List<KbOrderFundsVoucherModel> FundsVouchers
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

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
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

		[XmlElement("real_amount")]
		public string RealAmount
		{
			get;
			set;
		}

		[XmlElement("seller_id")]
		public string SellerId
		{
			get;
			set;
		}

		[XmlElement("shop")]
		public KbOrderShopModel Shop
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
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

		[XmlElement("trans_no")]
		public string TransNo
		{
			get;
			set;
		}

		[XmlArray("vouchers")]
		[XmlArrayItem("kb_order_voucher_model")]
		public List<KbOrderVoucherModel> Vouchers
		{
			get;
			set;
		}
	}
}
