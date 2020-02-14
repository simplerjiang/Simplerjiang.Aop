using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class YLBPriceDetailInfo : AopObject
	{
		[XmlElement("price_date")]
		public string PriceDate
		{
			get;
			set;
		}

		[XmlElement("sevendays_yeild_rate")]
		public string SevendaysYeildRate
		{
			get;
			set;
		}

		[XmlElement("tenthousand_income")]
		public string TenthousandIncome
		{
			get;
			set;
		}
	}
}
