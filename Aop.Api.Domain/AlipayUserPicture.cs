using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserPicture : AopObject
	{
		[XmlElement("picture_type")]
		public string PictureType
		{
			get;
			set;
		}

		[XmlElement("picture_url")]
		public string PictureUrl
		{
			get;
			set;
		}
	}
}
