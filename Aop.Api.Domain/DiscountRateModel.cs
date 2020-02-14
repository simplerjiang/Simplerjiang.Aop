using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DiscountRateModel : AopObject
	{
		[XmlElement("discount_dst_camp_prize_model")]
		public DiscountDstCampPrizeModel DiscountDstCampPrizeModel
		{
			get;
			set;
		}

		[XmlElement("lower_trade_fee")]
		public string LowerTradeFee
		{
			get;
			set;
		}

		[XmlElement("prize_type")]
		public string PrizeType
		{
			get;
			set;
		}

		[XmlElement("reduce_dst_camp_prize_model")]
		public ReduceDstCampPrizeModel ReduceDstCampPrizeModel
		{
			get;
			set;
		}

		[XmlElement("reduce_to_amt_dst_camp_prize_model")]
		public ReduceToAmtDstCampPrizeModel ReduceToAmtDstCampPrizeModel
		{
			get;
			set;
		}

		[XmlElement("single_dst_camp_prize_model")]
		public SingleDstCampPrizeModel SingleDstCampPrizeModel
		{
			get;
			set;
		}

		[XmlElement("upper_trade_fee")]
		public string UpperTradeFee
		{
			get;
			set;
		}
	}
}
