using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniSafedomainCreateModel : AopObject
	{
		[XmlElement("safe_domain")]
		public string SafeDomain
		{
			get;
			set;
		}
	}
}
