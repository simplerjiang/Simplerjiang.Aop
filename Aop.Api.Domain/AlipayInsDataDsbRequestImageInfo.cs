using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsDataDsbRequestImageInfo : AopObject
	{
		[XmlElement("image_name")]
		public string ImageName
		{
			get;
			set;
		}

		[XmlElement("image_path")]
		public string ImagePath
		{
			get;
			set;
		}
	}
}
