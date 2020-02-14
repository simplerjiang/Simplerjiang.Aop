using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertSpecialAdvContentModifyResponse : AopObject
	{
		[XmlElement("code")]
		public string Code
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

		[XmlElement("content_share_code")]
		public KbAdvertContentShareCode ContentShareCode
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

		[XmlElement("msg")]
		public string Msg
		{
			get;
			set;
		}
	}
}
