using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AdvertItem : AopObject
	{
		[XmlElement("img_url")]
		public string ImgUrl
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
