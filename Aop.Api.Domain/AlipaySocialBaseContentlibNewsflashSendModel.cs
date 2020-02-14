using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseContentlibNewsflashSendModel : AopObject
	{
		[XmlElement("author")]
		public string Author
		{
			get;
			set;
		}

		[XmlElement("content")]
		public string Content
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("images")]
		public string Images
		{
			get;
			set;
		}

		[XmlElement("opr_tags")]
		public string OprTags
		{
			get;
			set;
		}

		[XmlElement("publish_date")]
		public string PublishDate
		{
			get;
			set;
		}

		[XmlElement("recommend")]
		public long Recommend
		{
			get;
			set;
		}

		[XmlElement("source_channel_key")]
		public string SourceChannelKey
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

		[XmlElement("summary")]
		public string Summary
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
	}
}
