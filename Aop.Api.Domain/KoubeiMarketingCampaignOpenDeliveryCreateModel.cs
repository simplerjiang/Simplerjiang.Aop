using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignOpenDeliveryCreateModel : AopObject
	{
		[XmlElement("delivery_content")]
		public string DeliveryContent
		{
			get;
			set;
		}

		[XmlElement("delivery_type")]
		public string DeliveryType
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
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
	}
}
