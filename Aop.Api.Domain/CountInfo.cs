using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CountInfo : AopObject
	{
		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}

		[XmlElement("support_count")]
		public long SupportCount
		{
			get;
			set;
		}

		[XmlElement("total_page_view_count")]
		public long TotalPageViewCount
		{
			get;
			set;
		}
	}
}
