using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CommonDescInfo : AopObject
	{
		[XmlElement("img")]
		public string Img
		{
			get;
			set;
		}

		[XmlElement("text")]
		public string Text
		{
			get;
			set;
		}
	}
}
