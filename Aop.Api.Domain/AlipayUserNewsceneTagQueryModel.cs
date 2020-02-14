using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserNewsceneTagQueryModel : AopObject
	{
		[XmlElement("principal")]
		public AlipayUserPrincipalInfo Principal
		{
			get;
			set;
		}

		[XmlElement("query_tags")]
		public string QueryTags
		{
			get;
			set;
		}

		[XmlElement("scene")]
		public string Scene
		{
			get;
			set;
		}
	}
}
