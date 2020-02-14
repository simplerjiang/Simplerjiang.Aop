using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayToolsFileUploadResponse : AopResponse
	{
		[XmlElement("file_url")]
		public string FileUrl
		{
			get;
			set;
		}
	}
}
