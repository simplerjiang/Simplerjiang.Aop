using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TradeFundBill : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("fund_channel")]
		public string FundChannel
		{
			get;
			set;
		}

		[XmlElement("fund_type")]
		public string FundType
		{
			get;
			set;
		}

		[XmlElement("real_amount")]
		public string RealAmount
		{
			get;
			set;
		}
	}
}
