using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaMerchantDataUploadInitializeResponse : AopResponse
	{
		[XmlElement("template_url")]
		public string TemplateUrl
		{
			get;
			set;
		}
	}
}
