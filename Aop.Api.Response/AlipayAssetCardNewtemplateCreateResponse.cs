using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAssetCardNewtemplateCreateResponse : AopResponse
	{
		[XmlElement("template_id")]
		public string TemplateId
		{
			get;
			set;
		}
	}
}
