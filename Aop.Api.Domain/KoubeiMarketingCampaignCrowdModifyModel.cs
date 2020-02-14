using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignCrowdModifyModel : AopObject
	{
		[XmlElement("conditions")]
		public string Conditions
		{
			get;
			set;
		}

		[XmlElement("crowd_group_id")]
		public string CrowdGroupId
		{
			get;
			set;
		}

		[XmlElement("operator_id")]
		public string OperatorId
		{
			get;
			set;
		}

		[XmlElement("operator_type")]
		public string OperatorType
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}
	}
}
