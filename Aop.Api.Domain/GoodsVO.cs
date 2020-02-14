using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class GoodsVO : AopObject
	{
		[XmlElement("addition_desc")]
		public string AdditionDesc
		{
			get;
			set;
		}

		[XmlElement("barcode")]
		public string Barcode
		{
			get;
			set;
		}

		[XmlElement("biz_status")]
		public string BizStatus
		{
			get;
			set;
		}

		[XmlElement("box_num")]
		public long BoxNum
		{
			get;
			set;
		}

		[XmlElement("cainiao_item_code")]
		public string CainiaoItemCode
		{
			get;
			set;
		}

		[XmlElement("category")]
		public string Category
		{
			get;
			set;
		}

		[XmlElement("category_id")]
		public string CategoryId
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

		[XmlElement("goods_name")]
		public string GoodsName
		{
			get;
			set;
		}

		[XmlElement("last_operate_time")]
		public string LastOperateTime
		{
			get;
			set;
		}

		[XmlElement("last_operator")]
		public string LastOperator
		{
			get;
			set;
		}

		[XmlElement("origin_price")]
		public string OriginPrice
		{
			get;
			set;
		}

		[XmlElement("price")]
		public string Price
		{
			get;
			set;
		}

		[XmlElement("produce_price")]
		public string ProducePrice
		{
			get;
			set;
		}

		[XmlElement("producer_id")]
		public string ProducerId
		{
			get;
			set;
		}

		[XmlElement("producer_name")]
		public string ProducerName
		{
			get;
			set;
		}

		[XmlElement("sale_limit")]
		public long SaleLimit
		{
			get;
			set;
		}

		[XmlElement("specifications")]
		public string Specifications
		{
			get;
			set;
		}

		[XmlElement("storage_time")]
		public long StorageTime
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

		[XmlElement("tax_rate")]
		public string TaxRate
		{
			get;
			set;
		}
	}
}
