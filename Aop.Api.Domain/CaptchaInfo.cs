using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CaptchaInfo : AopObject
	{
		[XmlElement("captcha_desc")]
		public string CaptchaDesc
		{
			get;
			set;
		}

		[XmlElement("image_content")]
		public string ImageContent
		{
			get;
			set;
		}

		[XmlElement("image_type")]
		public string ImageType
		{
			get;
			set;
		}
	}
}
