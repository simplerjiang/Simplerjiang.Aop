using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BenefitInfoDetail : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("benefit_type")]
		public string BenefitType
		{
			get;
			set;
		}

		[XmlElement("count")]
		public string Count
		{
			get;
			set;
		}

		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}
	}
}
