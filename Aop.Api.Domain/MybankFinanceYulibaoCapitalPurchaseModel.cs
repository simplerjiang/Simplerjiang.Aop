using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankFinanceYulibaoCapitalPurchaseModel : AopObject
	{
		[XmlElement("amount")]
		public long Amount
		{
			get;
			set;
		}

		[XmlElement("currency")]
		public string Currency
		{
			get;
			set;
		}

		[XmlElement("fund_code")]
		public string FundCode
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}
	}
}
