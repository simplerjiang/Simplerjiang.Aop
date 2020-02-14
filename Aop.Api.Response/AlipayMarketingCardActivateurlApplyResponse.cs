using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardActivateurlApplyResponse : AopResponse
	{
		[XmlElement("apply_card_url")]
		public string ApplyCardUrl
		{
			get;
			set;
		}
	}
}
