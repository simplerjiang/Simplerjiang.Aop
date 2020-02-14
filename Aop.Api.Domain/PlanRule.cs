using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PlanRule : AopObject
	{
		[XmlElement("fixed_value")]
		public string FixedValue
		{
			get;
			set;
		}

		[XmlElement("range_end_value")]
		public string RangeEndValue
		{
			get;
			set;
		}

		[XmlElement("range_start_value")]
		public string RangeStartValue
		{
			get;
			set;
		}

		[XmlElement("rule_desc")]
		public string RuleDesc
		{
			get;
			set;
		}

		[XmlElement("rule_name")]
		public string RuleName
		{
			get;
			set;
		}

		[XmlElement("rule_type")]
		public string RuleType
		{
			get;
			set;
		}
	}
}
