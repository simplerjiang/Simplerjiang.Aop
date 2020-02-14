using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ActivityPlanInfo : AopObject
	{
		[XmlElement("activity_end_time")]
		public string ActivityEndTime
		{
			get;
			set;
		}

		[XmlElement("activity_start_time")]
		public string ActivityStartTime
		{
			get;
			set;
		}

		[XmlElement("confirm_end_time")]
		public string ConfirmEndTime
		{
			get;
			set;
		}

		[XmlElement("invite_order_id")]
		public string InviteOrderId
		{
			get;
			set;
		}

		[XmlArray("plan_rule_list")]
		[XmlArrayItem("plan_rule")]
		public List<PlanRule> PlanRuleList
		{
			get;
			set;
		}

		[XmlElement("plat_activity_agreement")]
		public string PlatActivityAgreement
		{
			get;
			set;
		}

		[XmlElement("plat_activity_id")]
		public string PlatActivityId
		{
			get;
			set;
		}

		[XmlElement("plat_activity_label_type")]
		public string PlatActivityLabelType
		{
			get;
			set;
		}

		[XmlElement("plat_activity_name")]
		public string PlatActivityName
		{
			get;
			set;
		}

		[XmlElement("plat_activity_rule_desc")]
		public string PlatActivityRuleDesc
		{
			get;
			set;
		}

		[XmlElement("plat_activity_status")]
		public string PlatActivityStatus
		{
			get;
			set;
		}

		[XmlElement("plat_other_desc")]
		public string PlatOtherDesc
		{
			get;
			set;
		}
	}
}
