using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayChinareModelResult : AopObject
	{
		[XmlElement("id")]
		public string Id
		{
			get;
			set;
		}

		[XmlElement("rule_id")]
		public string RuleId
		{
			get;
			set;
		}

		[XmlElement("rule_result")]
		public string RuleResult
		{
			get;
			set;
		}

		[XmlElement("trans_id")]
		public string TransId
		{
			get;
			set;
		}
	}
}
