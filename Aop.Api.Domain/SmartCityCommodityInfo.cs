using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SmartCityCommodityInfo : AopObject
	{
		[XmlElement("affiliation")]
		public string Affiliation
		{
			get;
			set;
		}

		[XmlElement("auth_file")]
		public string AuthFile
		{
			get;
			set;
		}

		[XmlElement("test_detail")]
		public string TestDetail
		{
			get;
			set;
		}

		[XmlElement("test_report")]
		public string TestReport
		{
			get;
			set;
		}

		[XmlElement("user_guide")]
		public string UserGuide
		{
			get;
			set;
		}
	}
}
