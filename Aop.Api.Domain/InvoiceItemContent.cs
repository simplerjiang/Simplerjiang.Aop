using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceItemContent : AopObject
	{
		[XmlElement("item_amount")]
		public string ItemAmount
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

		[XmlElement("item_no")]
		public string ItemNo
		{
			get;
			set;
		}

		[XmlElement("item_price")]
		public string ItemPrice
		{
			get;
			set;
		}

		[XmlElement("item_quantity")]
		public long ItemQuantity
		{
			get;
			set;
		}

		[XmlElement("item_sum_price")]
		public string ItemSumPrice
		{
			get;
			set;
		}

		[XmlElement("item_tax_price")]
		public string ItemTaxPrice
		{
			get;
			set;
		}

		[XmlElement("item_tax_rate")]
		public string ItemTaxRate
		{
			get;
			set;
		}

		[XmlElement("item_unit")]
		public string ItemUnit
		{
			get;
			set;
		}

		[XmlElement("row_type")]
		public long RowType
		{
			get;
			set;
		}
	}
}
