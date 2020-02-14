using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignRecruitApplyQueryResponse : AopResponse
	{
		[XmlElement("bought_time")]
		public string BoughtTime
		{
			get;
			set;
		}

		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("item_count")]
		public string ItemCount
		{
			get;
			set;
		}

		[XmlArray("item_info")]
		[XmlArrayItem("recruit_item_apply_data")]
		public List<RecruitItemApplyData> ItemInfo
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("prehot_time")]
		public string PrehotTime
		{
			get;
			set;
		}
	}
}
