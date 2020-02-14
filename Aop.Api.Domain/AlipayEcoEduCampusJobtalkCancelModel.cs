using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoEduCampusJobtalkCancelModel : AopObject
	{
		[XmlElement("content_var")]
		public string ContentVar
		{
			get;
			set;
		}

		[XmlElement("talk_source_code")]
		public string TalkSourceCode
		{
			get;
			set;
		}

		[XmlElement("talk_source_id")]
		public string TalkSourceId
		{
			get;
			set;
		}
	}
}
