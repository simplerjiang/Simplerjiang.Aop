using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataTradeHabbitQueryResponse : AopResponse
	{
		[XmlElement("trade_habit_info")]
		public string TradeHabitInfo
		{
			get;
			set;
		}
	}
}
