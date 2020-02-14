using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertCommissionBillQueryResponse : AopResponse
	{
		[XmlElement("date")]
		public string Date
		{
			get;
			set;
		}

		[XmlElement("deal_bill")]
		public KbAdvertDealBillResponse DealBill
		{
			get;
			set;
		}

		[XmlElement("settle_bill")]
		public KbAdvertSettleBillResponse SettleBill
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
	}
}
