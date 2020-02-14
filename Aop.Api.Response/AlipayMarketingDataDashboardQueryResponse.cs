using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingDataDashboardQueryResponse : AopResponse
	{
		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
