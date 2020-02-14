using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditEpCodecCreateResponse : AopResponse
	{
		[XmlElement("codec_img_url")]
		public string CodecImgUrl
		{
			get;
			set;
		}

		[XmlElement("token")]
		public string Token
		{
			get;
			set;
		}
	}
}
