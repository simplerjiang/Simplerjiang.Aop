using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsDataAutodamageImageUploadResponse : AopResponse
	{
		[XmlElement("image_path")]
		public string ImagePath
		{
			get;
			set;
		}
	}
}
