using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InventoryRecord : AopObject
	{
		[XmlElement("after_modify_lock_quantity")]
		public long AfterModifyLockQuantity
		{
			get;
			set;
		}

		[XmlElement("after_modify_quantity")]
		public long AfterModifyQuantity
		{
			get;
			set;
		}

		[XmlElement("batch_code")]
		public string BatchCode
		{
			get;
			set;
		}

		[XmlElement("before_modify_lock_quantity")]
		public string BeforeModifyLockQuantity
		{
			get;
			set;
		}

		[XmlElement("before_modify_quantity")]
		public long BeforeModifyQuantity
		{
			get;
			set;
		}

		[XmlElement("diff_lock_quantity")]
		public long DiffLockQuantity
		{
			get;
			set;
		}

		[XmlElement("diff_quantity")]
		public long DiffQuantity
		{
			get;
			set;
		}

		[XmlElement("expire_date")]
		public string ExpireDate
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

		[XmlElement("goods_code")]
		public string GoodsCode
		{
			get;
			set;
		}

		[XmlElement("inventory_type")]
		public string InventoryType
		{
			get;
			set;
		}

		[XmlElement("operate_type")]
		public string OperateType
		{
			get;
			set;
		}

		[XmlElement("out_biz_id")]
		public string OutBizId
		{
			get;
			set;
		}

		[XmlElement("product_date")]
		public string ProductDate
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}

		[XmlElement("warehouse_code")]
		public string WarehouseCode
		{
			get;
			set;
		}
	}
}
