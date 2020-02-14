using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InputFieldModel : AopObject
	{
		[XmlElement("default_value")]
		public string DefaultValue
		{
			get;
			set;
		}

		[XmlElement("field_name")]
		public string FieldName
		{
			get;
			set;
		}

		[XmlElement("field_tips")]
		public string FieldTips
		{
			get;
			set;
		}

		[XmlElement("field_title")]
		public string FieldTitle
		{
			get;
			set;
		}

		[XmlElement("field_type")]
		public string FieldType
		{
			get;
			set;
		}

		[XmlElement("priority")]
		public string Priority
		{
			get;
			set;
		}

		[XmlArray("regexp_rule_list")]
		[XmlArrayItem("validation_rule")]
		public List<ValidationRule> RegexpRuleList
		{
			get;
			set;
		}
	}
}
