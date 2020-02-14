using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MaintainVehicleInfo : AopObject
	{
		[XmlElement("bg_url")]
		public string BgUrl
		{
			get;
			set;
		}

		[XmlElement("engine_no")]
		public string EngineNo
		{
			get;
			set;
		}

		[XmlElement("engine_type")]
		public string EngineType
		{
			get;
			set;
		}

		[XmlElement("manufacturer")]
		public string Manufacturer
		{
			get;
			set;
		}

		[XmlElement("model_id")]
		public string ModelId
		{
			get;
			set;
		}

		[XmlElement("production_year")]
		public string ProductionYear
		{
			get;
			set;
		}

		[XmlArray("swept_volume")]
		[XmlArrayItem("string")]
		public List<string> SweptVolume
		{
			get;
			set;
		}

		[XmlElement("vi_brand_logo")]
		public string ViBrandLogo
		{
			get;
			set;
		}

		[XmlElement("vi_brand_name")]
		public string ViBrandName
		{
			get;
			set;
		}

		[XmlElement("vi_city_id")]
		public string ViCityId
		{
			get;
			set;
		}

		[XmlElement("vi_city_name")]
		public string ViCityName
		{
			get;
			set;
		}

		[XmlElement("vi_logo_url")]
		public string ViLogoUrl
		{
			get;
			set;
		}

		[XmlElement("vi_mileage")]
		public string ViMileage
		{
			get;
			set;
		}

		[XmlElement("vi_model_name")]
		public string ViModelName
		{
			get;
			set;
		}

		[XmlElement("vi_number")]
		public string ViNumber
		{
			get;
			set;
		}

		[XmlElement("vi_series_name")]
		public string ViSeriesName
		{
			get;
			set;
		}

		[XmlElement("vi_start_time")]
		public string ViStartTime
		{
			get;
			set;
		}

		[XmlElement("vi_style_name")]
		public string ViStyleName
		{
			get;
			set;
		}

		[XmlArray("vi_vin")]
		[XmlArrayItem("string")]
		public List<string> ViVin
		{
			get;
			set;
		}

		[XmlElement("vl_start_time")]
		public string VlStartTime
		{
			get;
			set;
		}
	}
}
