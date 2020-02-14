using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FaceSearchAnonymousUserInfo : AopObject
	{
		[XmlElement("merchantid")]
		public string Merchantid
		{
			get;
			set;
		}

		[XmlElement("merchantuid")]
		public string Merchantuid
		{
			get;
			set;
		}
	}
}
