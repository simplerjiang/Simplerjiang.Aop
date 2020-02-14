using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IdCardImg : AopObject
	{
		[XmlElement("cardtype")]
		public string Cardtype
		{
			get;
			set;
		}

		[XmlElement("imgurls")]
		public string Imgurls
		{
			get;
			set;
		}

		[XmlElement("imgurltype")]
		public string Imgurltype
		{
			get;
			set;
		}
	}
}
