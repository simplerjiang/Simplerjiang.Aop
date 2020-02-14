using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingDataEquitySyncResponse : AopResponse
	{
		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
