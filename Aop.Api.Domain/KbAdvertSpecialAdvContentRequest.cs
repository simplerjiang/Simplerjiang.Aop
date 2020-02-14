using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertSpecialAdvContentRequest : AopObject
	{
		[XmlElement("content_password_modify")]
		public KbAdvertContentPasswordModify ContentPasswordModify
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
