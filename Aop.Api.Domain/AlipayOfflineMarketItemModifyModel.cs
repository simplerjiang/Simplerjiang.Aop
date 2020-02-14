using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketItemModifyModel : AopObject
	{
		[XmlElement("audit_rule")]
		public AlipayItemAuditRule AuditRule
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

		[XmlElement("inventory")]
		public long Inventory
		{
			get;
			set;
		}

		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
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

		[XmlElement("weight")]
		public long Weight
		{
			get;
			set;
		}
	}
}
