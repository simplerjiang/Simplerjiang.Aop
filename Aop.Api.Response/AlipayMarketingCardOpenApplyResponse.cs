using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardOpenApplyResponse : AopResponse
	{
		[XmlElement("card_info")]
		public MerchantCard CardInfo
		{
			get;
			set;
		}
	}
}
