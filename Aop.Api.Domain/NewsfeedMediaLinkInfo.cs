using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class NewsfeedMediaLinkInfo : AopObject
	{
		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}

		[XmlElement("content_source")]
		public string ContentSource
		{
			get;
			set;
		}

		[XmlElement("content_type")]
		public string ContentType
		{
			get;
			set;
		}

		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("thumb")]
		public string Thumb
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}

		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
