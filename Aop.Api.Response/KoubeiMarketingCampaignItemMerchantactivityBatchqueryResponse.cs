using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignItemMerchantactivityBatchqueryResponse : AopResponse
	{
		[XmlArray("activities")]
		[XmlArrayItem("merchant_online_activity_open_model")]
		public List<MerchantOnlineActivityOpenModel> Activities
		{
			get;
			set;
		}
	}
}
