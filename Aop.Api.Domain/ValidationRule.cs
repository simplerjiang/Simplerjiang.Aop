using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ValidationRule : AopObject
	{
		[XmlElement("error_msg")]
		public string ErrorMsg
		{
			get;
			set;
		}

		[XmlElement("rule_text")]
		public string RuleText
		{
			get;
			set;
		}
	}
}
