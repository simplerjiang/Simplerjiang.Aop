using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataAiserviceSmartpriceGetResponse : AopResponse
	{
		[XmlElement("promo_price_cent")]
		public long PromoPriceCent
		{
			get;
			set;
		}
	}
}
