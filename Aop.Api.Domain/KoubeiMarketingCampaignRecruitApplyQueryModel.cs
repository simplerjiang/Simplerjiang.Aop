using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignRecruitApplyQueryModel : AopObject
	{
		[XmlElement("camp_id")]
		public string CampId
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public string PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}
	}
}
