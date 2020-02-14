using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieSitesBatchqueryResponse : AopResponse
	{
		[XmlElement("data")]
		public FengdieSitesListRespModel Data
		{
			get;
			set;
		}
	}
}
