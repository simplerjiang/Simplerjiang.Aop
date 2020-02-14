using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PosOrderDeviceInfoVO : AopObject
	{
		[XmlElement("device_amt")]
		public string DeviceAmt
		{
			get;
			set;
		}

		[XmlElement("device_status")]
		public string DeviceStatus
		{
			get;
			set;
		}

		[XmlElement("device_type")]
		public string DeviceType
		{
			get;
			set;
		}

		[XmlElement("device_version")]
		public string DeviceVersion
		{
			get;
			set;
		}

		[XmlElement("implement_status")]
		public string ImplementStatus
		{
			get;
			set;
		}

		[XmlElement("service_status")]
		public string ServiceStatus
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("sn_no")]
		public string SnNo
		{
			get;
			set;
		}

		[XmlElement("warehouse_id")]
		public string WarehouseId
		{
			get;
			set;
		}

		[XmlElement("warehouse_type")]
		public string WarehouseType
		{
			get;
			set;
		}
	}
}
