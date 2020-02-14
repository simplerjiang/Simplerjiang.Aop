using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingUserulePidQueryResponse : AopResponse
	{
		[XmlElement("pids")]
		public string Pids
		{
			get;
			set;
		}
	}
}
