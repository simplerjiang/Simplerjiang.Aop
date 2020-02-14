using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMaterialImageDownloadResponse : AopResponse
	{
		[XmlArray("image_urls")]
		[XmlArrayItem("string")]
		public List<string> ImageUrls
		{
			get;
			set;
		}
	}
}
