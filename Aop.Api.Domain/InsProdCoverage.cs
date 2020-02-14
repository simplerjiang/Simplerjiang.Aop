using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsProdCoverage : AopObject
	{
		[XmlElement("coverage_desc")]
		public string CoverageDesc
		{
			get;
			set;
		}

		[XmlElement("coverage_name")]
		public string CoverageName
		{
			get;
			set;
		}

		[XmlElement("coverage_no")]
		public string CoverageNo
		{
			get;
			set;
		}

		[XmlElement("is_fixed_period")]
		public bool IsFixedPeriod
		{
			get;
			set;
		}

		[XmlArray("liabilities")]
		[XmlArrayItem("ins_liability")]
		public List<InsLiability> Liabilities
		{
			get;
			set;
		}

		[XmlArray("periods")]
		[XmlArrayItem("string")]
		public List<string> Periods
		{
			get;
			set;
		}

		[XmlElement("sum_insured")]
		public InsSumInsured SumInsured
		{
			get;
			set;
		}
	}
}
