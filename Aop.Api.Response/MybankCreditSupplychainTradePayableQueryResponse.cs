using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSupplychainTradePayableQueryResponse : AopResponse
	{
		[XmlElement("debt_amt")]
		public string DebtAmt
		{
			get;
			set;
		}

		[XmlElement("expire_date")]
		public string ExpireDate
		{
			get;
			set;
		}

		[XmlElement("if_enough")]
		public bool IfEnough
		{
			get;
			set;
		}

		[XmlElement("if_need_budget")]
		public bool IfNeedBudget
		{
			get;
			set;
		}

		[XmlElement("overdue_amt")]
		public string OverdueAmt
		{
			get;
			set;
		}

		[XmlElement("paid_amt")]
		public string PaidAmt
		{
			get;
			set;
		}

		[XmlElement("total_amt")]
		public string TotalAmt
		{
			get;
			set;
		}
	}
}
