using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniSafedomainDeleteModel : AopObject
	{
		[XmlElement("safe_domain")]
		public string SafeDomain
		{
			get;
			set;
		}
	}
}
