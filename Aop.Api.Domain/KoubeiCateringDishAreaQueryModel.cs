using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringDishAreaQueryModel : AopObject
	{
		[XmlElement("area_id")]
		public string AreaId
		{
			get;
			set;
		}

		[XmlElement("area_name")]
		public string AreaName
		{
			get;
			set;
		}

		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
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

		[XmlElement("tab_id")]
		public string TabId
		{
			get;
			set;
		}
	}
}
