using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayDataItemSalesRule : AopObject
	{
		[XmlElement("buyer_crowd_limit")]
		public string BuyerCrowdLimit
		{
			get;
			set;
		}

		[XmlElement("daily_sales_limit")]
		public long DailySalesLimit
		{
			get;
			set;
		}

		[XmlArray("user_sales_limit")]
		[XmlArrayItem("string")]
		public List<string> UserSalesLimit
		{
			get;
			set;
		}
	}
}
