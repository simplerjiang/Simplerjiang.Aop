using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AssetDeliveryItem : AopObject
	{
		[XmlElement("action_type")]
		public string ActionType
		{
			get;
			set;
		}

		[XmlElement("amount")]
		public long Amount
		{
			get;
			set;
		}

		[XmlElement("apply_order_id")]
		public string ApplyOrderId
		{
			get;
			set;
		}

		[XmlElement("assign_item_id")]
		public string AssignItemId
		{
			get;
			set;
		}

		[XmlElement("assign_out_order_id")]
		public string AssignOutOrderId
		{
			get;
			set;
		}

		[XmlElement("biz_tag")]
		public string BizTag
		{
			get;
			set;
		}

		[XmlElement("from_address")]
		public AssetDeliveryAddress FromAddress
		{
			get;
			set;
		}

		[XmlElement("gmt_assign")]
		public string GmtAssign
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

		[XmlElement("item_name")]
		public string ItemName
		{
			get;
			set;
		}

		[XmlElement("logistics_info")]
		public LogisticsInfo LogisticsInfo
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

		[XmlElement("parent_item_id")]
		public string ParentItemId
		{
			get;
			set;
		}

		[XmlElement("print_data")]
		public string PrintData
		{
			get;
			set;
		}

		[XmlElement("produce_order_item_id")]
		public string ProduceOrderItemId
		{
			get;
			set;
		}

		[XmlElement("record_type")]
		public string RecordType
		{
			get;
			set;
		}

		[XmlElement("supplier_id")]
		public string SupplierId
		{
			get;
			set;
		}

		[XmlElement("supplier_name")]
		public string SupplierName
		{
			get;
			set;
		}

		[XmlElement("to_address")]
		public AssetDeliveryAddress ToAddress
		{
			get;
			set;
		}
	}
}
