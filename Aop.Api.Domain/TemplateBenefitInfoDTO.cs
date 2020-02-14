using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TemplateBenefitInfoDTO : AopObject
	{
		[XmlArray("benefit_desc")]
		[XmlArrayItem("string")]
		public List<string> BenefitDesc
		{
			get;
			set;
		}

		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}

		[XmlElement("start_date")]
		public string StartDate
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
