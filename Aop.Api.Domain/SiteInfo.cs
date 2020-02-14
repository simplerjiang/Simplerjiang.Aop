using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SiteInfo : AopObject
	{
		[XmlElement("account")]
		public string Account
		{
			get;
			set;
		}

		[XmlElement("password")]
		public string Password
		{
			get;
			set;
		}

		[XmlElement("site_name")]
		public string SiteName
		{
			get;
			set;
		}

		[XmlElement("site_type")]
		public string SiteType
		{
			get;
			set;
		}

		[XmlElement("site_url")]
		public string SiteUrl
		{
			get;
			set;
		}
	}
}
