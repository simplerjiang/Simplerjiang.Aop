using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoLogisticsExpressPriceModifyModel : AopObject
	{
		[XmlElement("area_type")]
		public string AreaType
		{
			get;
			set;
		}

		[XmlElement("extra_weight_price")]
		public string ExtraWeightPrice
		{
			get;
			set;
		}

		[XmlElement("extra_weight_unit")]
		public long ExtraWeightUnit
		{
			get;
			set;
		}

		[XmlElement("from_code")]
		public string FromCode
		{
			get;
			set;
		}

		[XmlElement("logis_merch_code")]
		public string LogisMerchCode
		{
			get;
			set;
		}

		[XmlElement("preset_weight")]
		public long PresetWeight
		{
			get;
			set;
		}

		[XmlElement("preset_weight_price")]
		public string PresetWeightPrice
		{
			get;
			set;
		}

		[XmlElement("product_type_code")]
		public string ProductTypeCode
		{
			get;
			set;
		}

		[XmlElement("to_code")]
		public string ToCode
		{
			get;
			set;
		}
	}
}
