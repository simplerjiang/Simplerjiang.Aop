using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringTablecodeQueryModel : AopObject
	{
		[XmlElement("url_context")]
		public string UrlContext
		{
			get;
			set;
		}
	}
}
