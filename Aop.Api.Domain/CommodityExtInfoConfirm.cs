using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CommodityExtInfoConfirm : AopObject
	{
		[XmlElement("city_status")]
		public string CityStatus
		{
			get;
			set;
		}

		[XmlElement("displayapp_id")]
		public string DisplayappId
		{
			get;
			set;
		}

		[XmlElement("mapping_displayapp_id")]
		public string MappingDisplayappId
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}
	}
}
