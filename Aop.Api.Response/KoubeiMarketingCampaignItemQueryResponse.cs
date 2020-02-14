using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignItemQueryResponse : AopResponse
	{
		[XmlElement("item")]
		public PromoItemInfo Item
		{
			get;
			set;
		}
	}
}
