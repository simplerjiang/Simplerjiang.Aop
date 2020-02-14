using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduCampusJobPublishModel : AopObject
	{
		[XmlElement("gmt_expired")]
		public string GmtExpired
		{
			get;
			set;
		}

		[XmlElement("gmt_refresh")]
		public string GmtRefresh
		{
			get;
			set;
		}

		[XmlElement("source_code")]
		public string SourceCode
		{
			get;
			set;
		}

		[XmlElement("source_id")]
		public string SourceId
		{
			get;
			set;
		}
	}
}
