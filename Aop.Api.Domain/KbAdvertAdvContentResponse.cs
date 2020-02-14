using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertAdvContentResponse : AopObject
	{
		[XmlElement("content_codec")]
		public KbAdvertContentCodec ContentCodec
		{
			get;
			set;
		}

		[XmlElement("content_password")]
		public KbAdvertContentPassword ContentPassword
		{
			get;
			set;
		}

		[XmlArray("content_share_code")]
		[XmlArrayItem("kb_advert_content_share_code")]
		public List<KbAdvertContentShareCode> ContentShareCode
		{
			get;
			set;
		}

		[XmlElement("content_short_link")]
		public KbAdvertContentShortLink ContentShortLink
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
	}
}
