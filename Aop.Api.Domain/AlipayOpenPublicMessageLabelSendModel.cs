using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicMessageLabelSendModel : AopObject
	{
		[XmlElement("filter")]
		public Filter Filter
		{
			get;
			set;
		}

		[XmlElement("material")]
		public Material Material
		{
			get;
			set;
		}
	}
}
