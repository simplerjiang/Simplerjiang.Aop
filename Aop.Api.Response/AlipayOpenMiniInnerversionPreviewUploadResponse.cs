using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniInnerversionPreviewUploadResponse : AopResponse
	{
		[XmlElement("build_package_url")]
		public string BuildPackageUrl
		{
			get;
			set;
		}
	}
}
