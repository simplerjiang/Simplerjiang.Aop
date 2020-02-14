using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDaoweiServiceModifyModel : AopObject
	{
		[XmlArray("assurance_desc")]
		[XmlArrayItem("assurance_info")]
		public List<AssuranceInfo> AssuranceDesc
		{
			get;
			set;
		}

		[XmlArray("attention")]
		[XmlArrayItem("common_desc_info")]
		public List<CommonDescInfo> Attention
		{
			get;
			set;
		}

		[XmlElement("category_code")]
		public string CategoryCode
		{
			get;
			set;
		}

		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlArray("desc")]
		[XmlArrayItem("common_desc_info")]
		public List<CommonDescInfo> Desc
		{
			get;
			set;
		}

		[XmlArray("district_code_list")]
		[XmlArrayItem("string")]
		public List<string> DistrictCodeList
		{
			get;
			set;
		}

		[XmlArray("image_urls")]
		[XmlArrayItem("string")]
		public List<string> ImageUrls
		{
			get;
			set;
		}

		[XmlElement("latitude")]
		public string Latitude
		{
			get;
			set;
		}

		[XmlElement("longitude")]
		public string Longitude
		{
			get;
			set;
		}

		[XmlElement("mode")]
		public string Mode
		{
			get;
			set;
		}

		[XmlElement("out_service_id")]
		public string OutServiceId
		{
			get;
			set;
		}

		[XmlElement("out_sp_id")]
		public string OutSpId
		{
			get;
			set;
		}

		[XmlArray("price_desc")]
		[XmlArrayItem("common_desc_info")]
		public List<CommonDescInfo> PriceDesc
		{
			get;
			set;
		}

		[XmlElement("price_dim_type")]
		public string PriceDimType
		{
			get;
			set;
		}

		[XmlArray("process_desc")]
		[XmlArrayItem("common_desc_info")]
		public List<CommonDescInfo> ProcessDesc
		{
			get;
			set;
		}

		[XmlArray("property")]
		[XmlArrayItem("sku_property_info")]
		public List<SkuPropertyInfo> Property
		{
			get;
			set;
		}

		[XmlElement("quantity")]
		public long Quantity
		{
			get;
			set;
		}

		[XmlElement("service_name")]
		public string ServiceName
		{
			get;
			set;
		}

		[XmlElement("service_range")]
		public string ServiceRange
		{
			get;
			set;
		}

		[XmlArray("sku")]
		[XmlArrayItem("sku_desc_info")]
		public List<SkuDescInfo> Sku
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("tags")]
		public string Tags
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}

		[XmlElement("unit")]
		public string Unit
		{
			get;
			set;
		}

		[XmlElement("unit_price")]
		public string UnitPrice
		{
			get;
			set;
		}
	}
}
