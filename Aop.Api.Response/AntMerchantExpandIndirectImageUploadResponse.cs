using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandIndirectImageUploadResponse : AopResponse
	{
		[XmlElement("image_id")]
		public string ImageId
		{
			get;
			set;
		}
	}
}
