using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CardDomainVO : AopObject
	{
		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}

		[XmlElement("domain_name")]
		public string DomainName
		{
			get;
			set;
		}
	}
}
