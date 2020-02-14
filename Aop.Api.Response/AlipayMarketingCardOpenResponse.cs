using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardOpenResponse : AopResponse
	{
		[XmlElement("card_info")]
		public MerchantCard CardInfo
		{
			get;
			set;
		}

		[XmlElement("open_card_channel")]
		public string OpenCardChannel
		{
			get;
			set;
		}

		[XmlElement("open_card_channel_id")]
		public string OpenCardChannelId
		{
			get;
			set;
		}
	}
}
