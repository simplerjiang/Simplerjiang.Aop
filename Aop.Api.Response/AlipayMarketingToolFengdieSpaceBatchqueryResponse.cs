using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieSpaceBatchqueryResponse : AopResponse
	{
		[XmlElement("data")]
		public FengdieSpaceListRespModel Data
		{
			get;
			set;
		}
	}
}
