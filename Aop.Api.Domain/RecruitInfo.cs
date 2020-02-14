using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RecruitInfo : AopObject
	{
		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("exclude_constraint_shops")]
		public bool ExcludeConstraintShops
		{
			get;
			set;
		}

		[XmlElement("plan_id")]
		public string PlanId
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
