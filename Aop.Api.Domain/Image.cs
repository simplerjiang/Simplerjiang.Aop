using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class Image : AopObject
	{
		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
