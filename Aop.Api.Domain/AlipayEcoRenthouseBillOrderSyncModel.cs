using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseBillOrderSyncModel : AopObject
	{
		[XmlElement("bill_number")]
		public string BillNumber
		{
			get;
			set;
		}

		[XmlArray("bills")]
		[XmlArrayItem("alipay_eco_renthouse_bill")]
		public List<AlipayEcoRenthouseBill> Bills
		{
			get;
			set;
		}

		[XmlElement("trade_id")]
		public string TradeId
		{
			get;
			set;
		}
	}
}
