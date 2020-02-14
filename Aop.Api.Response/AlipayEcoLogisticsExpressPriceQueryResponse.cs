using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoLogisticsExpressPriceQueryResponse : AopResponse
	{
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
	}
}
