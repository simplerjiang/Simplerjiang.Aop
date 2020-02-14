using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsSumInsured : AopObject
	{
		[XmlElement("default_value")]
		public long DefaultValue
		{
			get;
			set;
		}

		[XmlElement("max_value")]
		public long MaxValue
		{
			get;
			set;
		}

		[XmlElement("min_value")]
		public long MinValue
		{
			get;
			set;
		}

		[XmlElement("sum_insured_type")]
		public string SumInsuredType
		{
			get;
			set;
		}

		[XmlArray("sum_insureds")]
		[XmlArrayItem("number")]
		public List<long> SumInsureds
		{
			get;
			set;
		}
	}
}
