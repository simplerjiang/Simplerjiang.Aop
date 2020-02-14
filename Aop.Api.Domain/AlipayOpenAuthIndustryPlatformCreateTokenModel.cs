using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAuthIndustryPlatformCreateTokenModel : AopObject
	{
		[XmlElement("isv_appid")]
		public string IsvAppid
		{
			get;
			set;
		}

		[XmlElement("scope")]
		public string Scope
		{
			get;
			set;
		}
	}
}
