using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicQrcodeCreateResponse : AopResponse
	{
		[XmlElement("code_img")]
		public string CodeImg
		{
			get;
			set;
		}

		[XmlElement("expire_second")]
		public string ExpireSecond
		{
			get;
			set;
		}
	}
}
