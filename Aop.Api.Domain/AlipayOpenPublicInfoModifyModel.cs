using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicInfoModifyModel : AopObject
	{
		[XmlElement("app_name")]
		public string AppName
		{
			get;
			set;
		}

		[XmlElement("auth_pic")]
		public string AuthPic
		{
			get;
			set;
		}

		[XmlElement("background_url")]
		public string BackgroundUrl
		{
			get;
			set;
		}

		[XmlElement("introduction")]
		public string Introduction
		{
			get;
			set;
		}

		[XmlElement("license_url")]
		public string LicenseUrl
		{
			get;
			set;
		}

		[XmlElement("logo_url")]
		public string LogoUrl
		{
			get;
			set;
		}

		[XmlElement("public_greeting")]
		public string PublicGreeting
		{
			get;
			set;
		}

		[XmlArray("shop_pics")]
		[XmlArrayItem("string")]
		public List<string> ShopPics
		{
			get;
			set;
		}
	}
}
