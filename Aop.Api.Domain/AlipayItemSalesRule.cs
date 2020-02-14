using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayItemSalesRule : AopObject
	{
		[XmlArray("buyer_crowd_limit")]
		[XmlArrayItem("string")]
		public List<string> BuyerCrowdLimit
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

		[XmlElement("user_sales_limit")]
		public string UserSalesLimit
		{
			get;
			set;
		}
	}
}
