using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsOption : AopObject
	{
		[XmlElement("coverage")]
		public string Coverage
		{
			get;
			set;
		}

		[XmlElement("coverage_text")]
		public string CoverageText
		{
			get;
			set;
		}
	}
}
