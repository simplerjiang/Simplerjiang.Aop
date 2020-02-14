using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BaseInfo : AopObject
	{
		[XmlElement("alipay_fuwu_name")]
		public string AlipayFuwuName
		{
			get;
			set;
		}

		[XmlElement("app_name")]
		public string AppName
		{
			get;
			set;
		}

		[XmlArray("contact_info")]
		[XmlArrayItem("contact_person_info")]
		public List<ContactPersonInfo> ContactInfo
		{
			get;
			set;
		}

		[XmlElement("logo_pic")]
		public string LogoPic
		{
			get;
			set;
		}

		[XmlElement("mcc_code")]
		public string MccCode
		{
			get;
			set;
		}

		[XmlElement("short_name")]
		public string ShortName
		{
			get;
			set;
		}

		[XmlArray("special_license_pic")]
		[XmlArrayItem("string")]
		public List<string> SpecialLicensePic
		{
			get;
			set;
		}

		[XmlElement("usage_scenario")]
		public string UsageScenario
		{
			get;
			set;
		}

		[XmlArray("web_address")]
		[XmlArrayItem("string")]
		public List<string> WebAddress
		{
			get;
			set;
		}

		[XmlElement("web_auth_pic")]
		public string WebAuthPic
		{
			get;
			set;
		}

		[XmlElement("weixin_public_name")]
		public string WeixinPublicName
		{
			get;
			set;
		}
	}
}
