using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieTemplateBatchqueryResponse : AopResponse
	{
		[XmlElement("data")]
		public FengdieTemplateListRespModel Data
		{
			get;
			set;
		}
	}
}
