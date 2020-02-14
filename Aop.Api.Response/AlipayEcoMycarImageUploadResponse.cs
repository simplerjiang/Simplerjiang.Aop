using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarImageUploadResponse : AopResponse
	{
		[XmlElement("img_id")]
		public string ImgId
		{
			get;
			set;
		}

		[XmlElement("img_url")]
		public string ImgUrl
		{
			get;
			set;
		}
	}
}
