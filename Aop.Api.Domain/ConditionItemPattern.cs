using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ConditionItemPattern : AopObject
	{
		[XmlElement("logical_operator")]
		public string LogicalOperator
		{
			get;
			set;
		}

		[XmlElement("operation_value")]
		public string OperationValue
		{
			get;
			set;
		}

		[XmlElement("operator_rule")]
		public string OperatorRule
		{
			get;
			set;
		}

		[XmlElement("period")]
		public string Period
		{
			get;
			set;
		}

		[XmlElement("rule_unit")]
		public string RuleUnit
		{
			get;
			set;
		}
	}
}
