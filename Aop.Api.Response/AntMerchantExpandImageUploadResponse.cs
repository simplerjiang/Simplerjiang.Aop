using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandImageUploadResponse : AopResponse
	{
		[XmlElement("image_id")]
		public string ImageId
		{
			get;
			set;
		}
	}
}
