using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MiniPackageInfo : AopObject
	{
		[XmlElement("doc_url")]
		public string DocUrl
		{
			get;
			set;
		}

		[XmlElement("package_desc")]
		public string PackageDesc
		{
			get;
			set;
		}

		[XmlElement("package_name")]
		public string PackageName
		{
			get;
			set;
		}

		[XmlElement("package_open_type")]
		public string PackageOpenType
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
