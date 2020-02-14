using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsAutoAutoinsprodQuoteApplyModel : AopObject
	{
		[XmlElement("business_product")]
		public InsProduct BusinessProduct
		{
			get;
			set;
		}

		[XmlElement("check_code")]
		public string CheckCode
		{
			get;
			set;
		}

		[XmlElement("check_code_id")]
		public string CheckCodeId
		{
			get;
			set;
		}

		[XmlElement("check_type")]
		public string CheckType
		{
			get;
			set;
		}

		[XmlElement("company_id")]
		public string CompanyId
		{
			get;
			set;
		}

		[XmlElement("enquiry_biz_id")]
		public string EnquiryBizId
		{
			get;
			set;
		}

		[XmlElement("force_product")]
		public InsProduct ForceProduct
		{
			get;
			set;
		}

		[XmlElement("quote_type")]
		public string QuoteType
		{
			get;
			set;
		}
	}
}
