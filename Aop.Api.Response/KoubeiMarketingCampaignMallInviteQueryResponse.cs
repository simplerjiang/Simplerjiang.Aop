using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignMallInviteQueryResponse : AopResponse
	{
		[XmlArray("activity_plan_info_list")]
		[XmlArrayItem("activity_plan_info")]
		public List<ActivityPlanInfo> ActivityPlanInfoList
		{
			get;
			set;
		}
	}
}
