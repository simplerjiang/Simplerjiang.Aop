using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicLabelDeleteModel : AopObject
	{
		[XmlElement("id")]
		public string Id
		{
			get;
			set;
		}
	}
}
