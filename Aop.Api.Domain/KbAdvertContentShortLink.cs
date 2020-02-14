using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertContentShortLink : AopObject
	{
		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
