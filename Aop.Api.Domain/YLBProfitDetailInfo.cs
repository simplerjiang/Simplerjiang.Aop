using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class YLBProfitDetailInfo : AopObject
	{
		[XmlElement("day_profit")]
		public string DayProfit
		{
			get;
			set;
		}

		[XmlElement("month_profit")]
		public string MonthProfit
		{
			get;
			set;
		}

		[XmlElement("total_profit")]
		public string TotalProfit
		{
			get;
			set;
		}

		[XmlElement("week_profit")]
		public string WeekProfit
		{
			get;
			set;
		}
	}
}
