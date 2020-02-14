using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayIserviceCognitiveOcrDriverlicenseQueryModel : AopObject
	{
		[XmlElement("image_content")]
		public string ImageContent
		{
			get;
			set;
		}
	}
}
