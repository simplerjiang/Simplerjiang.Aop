using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniTemplatemessageUsertemplateApplyResponse : AopResponse
	{
		[XmlElement("user_template_id")]
		public string UserTemplateId
		{
			get;
			set;
		}
	}
}
