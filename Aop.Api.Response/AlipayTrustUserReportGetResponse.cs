using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTrustUserReportGetResponse : AopResponse
	{
		[XmlElement("report")]
		public string Report
		{
			get;
			set;
		}
	}
}
