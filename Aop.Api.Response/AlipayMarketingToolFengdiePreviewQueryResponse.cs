using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdiePreviewQueryResponse : AopResponse
	{
		[XmlElement("data")]
		public FengdiePreviewQueryRespModel Data
		{
			get;
			set;
		}
	}
}
