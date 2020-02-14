using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsLiability : AopObject
	{
		[XmlElement("coverage")]
		public string Coverage
		{
			get;
			set;
		}

		[XmlElement("disabled")]
		public string Disabled
		{
			get;
			set;
		}

		[XmlElement("iop")]
		public string Iop
		{
			get;
			set;
		}

		[XmlElement("iop_premium")]
		public string IopPremium
		{
			get;
			set;
		}

		[XmlElement("liability_desc")]
		public string LiabilityDesc
		{
			get;
			set;
		}

		[XmlElement("liability_name")]
		public string LiabilityName
		{
			get;
			set;
		}

		[XmlElement("liability_no")]
		public string LiabilityNo
		{
			get;
			set;
		}

		[XmlElement("liability_premium")]
		public string LiabilityPremium
		{
			get;
			set;
		}

		[XmlArray("options")]
		[XmlArrayItem("ins_option")]
		public List<InsOption> Options
		{
			get;
			set;
		}

		[XmlElement("premium")]
		public string Premium
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
