using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayIserviceCognitiveOcrVehicleplateQueryModel : AopObject
	{
		[XmlElement("image_content")]
		public string ImageContent
		{
			get;
			set;
		}
	}
}
