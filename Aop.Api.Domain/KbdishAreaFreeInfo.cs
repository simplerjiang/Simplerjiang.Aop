using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishAreaFreeInfo : AopObject
	{
		[XmlElement("area_id")]
		public string AreaId
		{
			get;
			set;
		}

		[XmlElement("count")]
		public string Count
		{
			get;
			set;
		}

		[XmlElement("dish_id")]
		public string DishId
		{
			get;
			set;
		}

		[XmlElement("dish_sku_id")]
		public string DishSkuId
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
	}
}
