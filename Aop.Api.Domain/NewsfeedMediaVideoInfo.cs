using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class NewsfeedMediaVideoInfo : AopObject
	{
		[XmlElement("height")]
		public string Height
		{
			get;
			set;
		}

		[XmlElement("img_id")]
		public string ImgId
		{
			get;
			set;
		}

		[XmlElement("video_id")]
		public string VideoId
		{
			get;
			set;
		}

		[XmlElement("width")]
		public string Width
		{
			get;
			set;
		}
	}
}
