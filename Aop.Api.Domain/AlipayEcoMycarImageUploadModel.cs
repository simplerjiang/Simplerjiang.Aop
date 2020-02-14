using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarImageUploadModel : AopObject
	{
		[XmlElement("img_content")]
		public string ImgContent
		{
			get;
			set;
		}

		[XmlElement("img_type")]
		public string ImgType
		{
			get;
			set;
		}

		[XmlElement("scene_type")]
		public string SceneType
		{
			get;
			set;
		}
	}
}
