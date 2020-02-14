using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicLabelCreateModel : AopObject
	{
		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}
