using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class JFExportInputFieldModel : AopObject
	{
		[XmlElement("data_type")]
		public string DataType
		{
			get;
			set;
		}

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

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("mode_type")]
		public string ModeType
		{
			get;
			set;
		}

		[XmlElement("priority")]
		public long Priority
		{
			get;
			set;
		}

		[XmlArray("regexp_rules")]
		[XmlArrayItem("validation_rule")]
		public List<ValidationRule> RegexpRules
		{
			get;
			set;
		}
	}
}
