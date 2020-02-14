using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityDataInfoMobilecityQueryModel : AopObject
	{
		[XmlElement("phone")]
		public string Phone
		{
			get;
			set;
		}
	}
}
