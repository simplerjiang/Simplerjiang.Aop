using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicQrcodeCreateResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("code_img")]
		public string CodeImg
		{
			get;
			set;
		}

		[XmlElement("expire_second")]
		public long ExpireSecond
		{
			get;
			set;
		}

		[XmlElement("msg")]
		public new string Msg
		{
			get;
			set;
		}
	}
}
