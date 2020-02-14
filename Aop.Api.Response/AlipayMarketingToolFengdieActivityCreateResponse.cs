using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieActivityCreateResponse : AopResponse
	{
		[XmlElement("activity_id")]
		public long ActivityId
		{
			get;
			set;
		}
	}
}
