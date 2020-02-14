using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceItemOpenModel : AopObject
	{
		[XmlElement("item_ex_tax_amount")]
		public string ItemExTaxAmount
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

		[XmlElement("item_quantity")]
		public long ItemQuantity
		{
			get;
			set;
		}

		[XmlElement("item_spec")]
		public string ItemSpec
		{
			get;
			set;
		}

		[XmlElement("item_sum_amount")]
		public string ItemSumAmount
		{
			get;
			set;
		}

		[XmlElement("item_tax_amount")]
		public string ItemTaxAmount
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

		[XmlElement("item_unit_price")]
		public string ItemUnitPrice
		{
			get;
			set;
		}

		[XmlElement("row_type")]
		public string RowType
		{
			get;
			set;
		}
	}
}
