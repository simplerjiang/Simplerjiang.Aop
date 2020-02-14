using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayIserviceCognitiveOcrImageclassifyQueryModel : AopObject
	{
		[XmlElement("image_content")]
		public string ImageContent
		{
			get;
			set;
		}
	}
}
