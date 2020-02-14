using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMaterialImageUploadResponse : AopResponse
	{
		[XmlElement("image_id")]
		public string ImageId
		{
			get;
			set;
		}

		[XmlElement("image_url")]
		public string ImageUrl
		{
			get;
			set;
		}
	}
}
