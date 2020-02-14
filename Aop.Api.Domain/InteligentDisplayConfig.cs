using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentDisplayConfig : AopObject
	{
		[XmlElement("slogan")]
		public string Slogan
		{
			get;
			set;
		}

		[XmlElement("slogan_img")]
		public string SloganImg
		{
			get;
			set;
		}
	}
}
