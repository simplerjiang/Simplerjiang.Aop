using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AssetDeliveryAddress : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("city")]
		public string City
		{
			get;
			set;
		}

		[XmlElement("contact_name")]
		public string ContactName
		{
			get;
			set;
		}

		[XmlElement("contact_phone")]
		public string ContactPhone
		{
			get;
			set;
		}

		[XmlElement("district")]
		public string District
		{
			get;
			set;
		}

		[XmlElement("province")]
		public string Province
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

		[XmlElement("warehouse_name")]
		public string WarehouseName
		{
			get;
			set;
		}

		[XmlElement("zip_code")]
		public string ZipCode
		{
			get;
			set;
		}
	}
}
