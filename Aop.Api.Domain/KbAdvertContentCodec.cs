using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertContentCodec : AopObject
	{
		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
