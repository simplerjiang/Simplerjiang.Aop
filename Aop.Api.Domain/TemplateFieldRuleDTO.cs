using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TemplateFieldRuleDTO : AopObject
	{
		[XmlElement("field_name")]
		public string FieldName
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

		[XmlElement("rule_value")]
		public string RuleValue
		{
			get;
			set;
		}
	}
}
