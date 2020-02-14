using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CarModel : AopObject
	{
		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}

		[XmlElement("config_name")]
		public string ConfigName
		{
			get;
			set;
		}

		[XmlElement("engine_desc")]
		public string EngineDesc
		{
			get;
			set;
		}

		[XmlElement("family_short_name")]
		public string FamilyShortName
		{
			get;
			set;
		}

		[XmlElement("gear_box_type")]
		public string GearBoxType
		{
			get;
			set;
		}

		[XmlElement("purchase_price")]
		public string PurchasePrice
		{
			get;
			set;
		}

		[XmlElement("seat")]
		public string Seat
		{
			get;
			set;
		}

		[XmlElement("vehicle_class_code")]
		public string VehicleClassCode
		{
			get;
			set;
		}

		[XmlElement("vehicle_code")]
		public string VehicleCode
		{
			get;
			set;
		}

		[XmlElement("vehicle_name")]
		public string VehicleName
		{
			get;
			set;
		}

		[XmlElement("year_pattern")]
		public string YearPattern
		{
			get;
			set;
		}
	}
}
