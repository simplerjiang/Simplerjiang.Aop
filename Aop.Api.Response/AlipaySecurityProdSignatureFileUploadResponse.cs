using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdSignatureFileUploadResponse : AopResponse
	{
		[XmlElement("oss_file_id")]
		public string OssFileId
		{
			get;
			set;
		}
	}
}
