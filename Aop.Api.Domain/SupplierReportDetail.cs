using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SupplierReportDetail : AopObject
	{
		[XmlElement("batch_code")]
		public string BatchCode
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

		[XmlElement("price")]
		public string Price
		{
			get;
			set;
		}

		[XmlElement("production_date")]
		public string ProductionDate
		{
			get;
			set;
		}

		[XmlElement("quantity_diff")]
		public long QuantityDiff
		{
			get;
			set;
		}

		[XmlElement("report_type")]
		public string ReportType
		{
			get;
			set;
		}

		[XmlElement("supplier_report_detail_id")]
		public string SupplierReportDetailId
		{
			get;
			set;
		}

		[XmlElement("supplier_report_id")]
		public string SupplierReportId
		{
			get;
			set;
		}
	}
}
