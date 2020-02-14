using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IntelligentPromoShopSummaryInfo : AopObject
	{
		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("shop_name")]
		public string ShopName
		{
			get;
			set;
		}
	}
}
