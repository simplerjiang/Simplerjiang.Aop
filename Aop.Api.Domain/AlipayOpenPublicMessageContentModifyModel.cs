using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicMessageContentModifyModel : AopObject
	{
		[XmlElement("benefit")]
		public string Benefit
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

		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}

		[XmlElement("could_comment")]
		public string CouldComment
		{
			get;
			set;
		}

		[XmlElement("cover")]
		public string Cover
		{
			get;
			set;
		}

		[XmlElement("ctype")]
		public string Ctype
		{
			get;
			set;
		}

		[XmlElement("ext_tags")]
		public string ExtTags
		{
			get;
			set;
		}

		[XmlElement("login_ids")]
		public string LoginIds
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
