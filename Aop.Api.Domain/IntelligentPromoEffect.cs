using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IntelligentPromoEffect : AopObject
	{
		[XmlElement("avg_prize_increase")]
		public string AvgPrizeIncrease
		{
			get;
			set;
		}

		[XmlElement("cost")]
		public string Cost
		{
			get;
			set;
		}

		[XmlElement("current_total_amount")]
		public string CurrentTotalAmount
		{
			get;
			set;
		}

		[XmlElement("effect_id")]
		public string EffectId
		{
			get;
			set;
		}

		[XmlElement("gmt_from")]
		public string GmtFrom
		{
			get;
			set;
		}

		[XmlElement("gmt_to")]
		public string GmtTo
		{
			get;
			set;
		}

		[XmlElement("gmv")]
		public string Gmv
		{
			get;
			set;
		}

		[XmlElement("remain_stock_num")]
		public long RemainStockNum
		{
			get;
			set;
		}

		[XmlElement("repay_rate_increase")]
		public string RepayRateIncrease
		{
			get;
			set;
		}

		[XmlElement("send_count_increase")]
		public string SendCountIncrease
		{
			get;
			set;
		}

		[XmlElement("take_count")]
		public long TakeCount
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}

		[XmlElement("use_count")]
		public long UseCount
		{
			get;
			set;
		}
	}
}
