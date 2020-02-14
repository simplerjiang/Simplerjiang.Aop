using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicTemplateMessageIndustryModifyModel : AopObject
	{
		[XmlElement("primary_industry_code")]
		public string PrimaryIndustryCode
		{
			get;
			set;
		}

		[XmlElement("primary_industry_name")]
		public string PrimaryIndustryName
		{
			get;
			set;
		}

		[XmlElement("secondary_industry_code")]
		public string SecondaryIndustryCode
		{
			get;
			set;
		}

		[XmlElement("secondary_industry_name")]
		public string SecondaryIndustryName
		{
			get;
			set;
		}
	}
}
