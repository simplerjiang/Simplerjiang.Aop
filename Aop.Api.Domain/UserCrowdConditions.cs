using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class UserCrowdConditions : AopObject
	{
		[XmlElement("crowd_group_id")]
		public string CrowdGroupId
		{
			get;
			set;
		}

		[XmlElement("describe")]
		public string Describe
		{
			get;
			set;
		}

		[XmlArray("hit_crowd_conditons")]
		[XmlArrayItem("condition_item_pattern")]
		public List<ConditionItemPattern> HitCrowdConditons
		{
			get;
			set;
		}
	}
}
