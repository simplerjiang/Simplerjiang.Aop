using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenPublicLifeLabelDeleteModel : AopObject
	{
		[XmlElement("label_id")]
		public string LabelId
		{
			get;
			set;
		}
	}
}
