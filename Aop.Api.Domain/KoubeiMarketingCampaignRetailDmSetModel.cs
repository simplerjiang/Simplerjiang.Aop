using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignRetailDmSetModel : AopObject
	{
		[XmlElement("campaign_end_time")]
		public string CampaignEndTime
		{
			get;
			set;
		}

		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}

		[XmlElement("operate_type")]
		public string OperateType
		{
			get;
			set;
		}
	}
}
