using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FaceSearchUserInfo : AopObject
	{
		[XmlElement("customuserid")]
		public string Customuserid
		{
			get;
			set;
		}

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
