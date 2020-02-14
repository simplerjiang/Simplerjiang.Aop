using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniBaseinfoQueryResponse : AopResponse
	{
		[XmlElement("app_desc")]
		public string AppDesc
		{
			get;
			set;
		}

		[XmlElement("app_english_name")]
		public string AppEnglishName
		{
			get;
			set;
		}

		[XmlElement("app_logo")]
		public string AppLogo
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

		[XmlElement("app_slogan")]
		public string AppSlogan
		{
			get;
			set;
		}

		[XmlElement("category_names")]
		public string CategoryNames
		{
			get;
			set;
		}

		[XmlArray("package_names")]
		[XmlArrayItem("string")]
		public List<string> PackageNames
		{
			get;
			set;
		}

		[XmlArray("safe_domains")]
		[XmlArrayItem("string")]
		public List<string> SafeDomains
		{
			get;
			set;
		}

		[XmlElement("service_email")]
		public string ServiceEmail
		{
			get;
			set;
		}

		[XmlElement("service_phone")]
		public string ServicePhone
		{
			get;
			set;
		}
	}
}
