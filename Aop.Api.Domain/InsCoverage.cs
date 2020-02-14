using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsCoverage : AopObject
	{
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

		[XmlElement("effect_end_time")]
		public string EffectEndTime
		{
			get;
			set;
		}

		[XmlElement("effect_start_time")]
		public string EffectStartTime
		{
			get;
			set;
		}

		[XmlElement("iop")]
		public long Iop
		{
			get;
			set;
		}

		[XmlElement("iop_premium")]
		public long IopPremium
		{
			get;
			set;
		}

		[XmlElement("premium")]
		public long Premium
		{
			get;
			set;
		}

		[XmlElement("sum_insured")]
		public long SumInsured
		{
			get;
			set;
		}
	}
}
