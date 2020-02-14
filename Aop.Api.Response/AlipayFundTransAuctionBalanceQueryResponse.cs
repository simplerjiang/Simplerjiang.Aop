using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransAuctionBalanceQueryResponse : AopResponse
	{
		[XmlElement("balance_available")]
		public string BalanceAvailable
		{
			get;
			set;
		}

		[XmlElement("balance_freezed")]
		public string BalanceFreezed
		{
			get;
			set;
		}
	}
}
