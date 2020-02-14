using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DeliveryPackageVO : AopObject
	{
		[XmlElement("delivery_order_code")]
		public string DeliveryOrderCode
		{
			get;
			set;
		}

		[XmlElement("delivery_order_id")]
		public string DeliveryOrderId
		{
			get;
			set;
		}

		[XmlArray("delivery_package_detail_list")]
		[XmlArrayItem("delivery_package_detail")]
		public List<DeliveryPackageDetail> DeliveryPackageDetailList
		{
			get;
			set;
		}

		[XmlElement("express_code")]
		public string ExpressCode
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

		[XmlElement("logistics_code")]
		public string LogisticsCode
		{
			get;
			set;
		}

		[XmlElement("package_code")]
		public string PackageCode
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

		[XmlElement("work_order_id")]
		public string WorkOrderId
		{
			get;
			set;
		}
	}
}
