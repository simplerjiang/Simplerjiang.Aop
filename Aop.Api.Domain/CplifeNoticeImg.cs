using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CplifeNoticeImg : AopObject
	{
		[XmlElement("image_url")]
		public string ImageUrl
		{
			get;
			set;
		}

		[XmlElement("thumbnail_url")]
		public string ThumbnailUrl
		{
			get;
			set;
		}
	}
}
