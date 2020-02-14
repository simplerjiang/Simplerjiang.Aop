using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingFacetofaceDecodeUseResponse : AopResponse
	{
		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
