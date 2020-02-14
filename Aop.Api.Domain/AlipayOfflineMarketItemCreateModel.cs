using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketItemCreateModel : AopObject
	{
		[XmlElement("audit_rule")]
		public AlipayItemAuditRule AuditRule
		{
			get;
			set;
		}

		[XmlElement("cover")]
		public string Cover
		{
			get;
			set;
		}

		[XmlArray("descriptions")]
		[XmlArrayItem("alipay_item_description")]
		public List<AlipayItemDescription> Descriptions
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("gmt_start")]
		public string GmtStart
		{
			get;
			set;
		}

		[XmlElement("inventory")]
		public long Inventory
		{
			get;
			set;
		}

		[XmlElement("is_auto_expanded")]
		public bool IsAutoExpanded
		{
			get;
			set;
		}

		[XmlElement("item_type")]
		public string ItemType
		{
			get;
			set;
		}

		[XmlElement("operate_notify_url")]
		public string OperateNotifyUrl
		{
			get;
			set;
		}

		[XmlElement("operation_context")]
		public AlipayItemOperationContext OperationContext
		{
			get;
			set;
		}

		[XmlElement("purchase_mode")]
		public string PurchaseMode
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("sales_rule")]
		public AlipayItemSalesRule SalesRule
		{
			get;
			set;
		}

		[XmlElement("shop_list")]
		public string ShopList
		{
			get;
			set;
		}

		[XmlElement("subject")]
		public string Subject
		{
			get;
			set;
		}

		[XmlElement("voucher_templete")]
		public AlipayItemVoucherTemplete VoucherTemplete
		{
			get;
			set;
		}

		[XmlElement("weight")]
		public long Weight
		{
			get;
			set;
		}
	}
}
