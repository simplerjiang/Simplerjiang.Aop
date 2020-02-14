using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class QuoteInfo : AopObject
	{
		[XmlElement("company_id")]
		public string CompanyId
		{
			get;
			set;
		}

		[XmlElement("quote_biz_id")]
		public string QuoteBizId
		{
			get;
			set;
		}
	}
}
