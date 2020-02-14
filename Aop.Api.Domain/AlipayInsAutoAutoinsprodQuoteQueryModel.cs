using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsAutoAutoinsprodQuoteQueryModel : AopObject
	{
		[XmlElement("enquiry_biz_id")]
		public string EnquiryBizId
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
