using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TradeAssocBillDetails : AopObject
	{
		[XmlElement("acct_period")]
		public string AcctPeriod
		{
			get;
			set;
		}

		[XmlElement("bill_entry_amount")]
		public string BillEntryAmount
		{
			get;
			set;
		}

		[XmlElement("bill_entry_id")]
		public string BillEntryId
		{
			get;
			set;
		}

		[XmlElement("cost_type")]
		public string CostType
		{
			get;
			set;
		}
	}
}
