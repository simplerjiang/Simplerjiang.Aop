using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFinanceFundSimilarquotationQueryModel : AopObject
	{
		[XmlElement("fund_code")]
		public string FundCode
		{
			get;
			set;
		}
	}
}
