using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SupplierReport : AopObject
	{
		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}

		[XmlElement("operator_id")]
		public string OperatorId
		{
			get;
			set;
		}

		[XmlElement("operator_type")]
		public string OperatorType
		{
			get;
			set;
		}

		[XmlElement("order_date")]
		public string OrderDate
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

		[XmlElement("state")]
		public string State
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

		[XmlElement("supplier_report_id")]
		public string SupplierReportId
		{
			get;
			set;
		}

		[XmlElement("unique_id")]
		public string UniqueId
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
