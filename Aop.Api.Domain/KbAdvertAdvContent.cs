using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertAdvContent : AopObject
	{
		[XmlElement("codec")]
		public string Codec
		{
			get;
			set;
		}

		[XmlElement("link_url")]
		public string LinkUrl
		{
			get;
			set;
		}
	}
}
