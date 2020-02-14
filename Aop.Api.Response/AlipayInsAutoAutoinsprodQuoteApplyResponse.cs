using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoAutoinsprodQuoteApplyResponse : AopResponse
	{
		[XmlElement("enquiry_biz_id")]
		public string EnquiryBizId
		{
			get;
			set;
		}

		[XmlArray("quote_infos")]
		[XmlArrayItem("quote_info")]
		public List<QuoteInfo> QuoteInfos
		{
			get;
			set;
		}
	}
}
