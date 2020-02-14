using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignItemBatchqueryResponse : AopResponse
	{
		[XmlArray("items")]
		[XmlArrayItem("promo_item_info")]
		public List<PromoItemInfo> Items
		{
			get;
			set;
		}
	}
}
