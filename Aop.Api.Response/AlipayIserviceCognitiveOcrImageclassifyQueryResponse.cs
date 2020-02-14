using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayIserviceCognitiveOcrImageclassifyQueryResponse : AopResponse
	{
		[XmlElement("image_type")]
		public string ImageType
		{
			get;
			set;
		}
	}
}
