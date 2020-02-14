using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenServicemarketCommoditySmartcitySyncModel : AopObject
	{
		[XmlElement("commodity_base_info")]
		public CommodityBaseInfo CommodityBaseInfo
		{
			get;
			set;
		}

		[XmlElement("commodity_id")]
		public string CommodityId
		{
			get;
			set;
		}

		[XmlElement("is_pre")]
		public string IsPre
		{
			get;
			set;
		}

		[XmlElement("smart_city_commodity_info")]
		public SmartCityCommodityInfo SmartCityCommodityInfo
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
