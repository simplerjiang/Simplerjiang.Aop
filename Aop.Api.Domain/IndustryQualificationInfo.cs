using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IndustryQualificationInfo : AopObject
	{
		[XmlElement("industry_qualification_image")]
		public string IndustryQualificationImage
		{
			get;
			set;
		}

		[XmlElement("industry_qualification_type")]
		public string IndustryQualificationType
		{
			get;
			set;
		}
	}
}
