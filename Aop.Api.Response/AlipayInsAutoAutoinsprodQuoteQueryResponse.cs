using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoAutoinsprodQuoteQueryResponse : AopResponse
	{
		[XmlElement("business_premium")]
		public string BusinessPremium
		{
			get;
			set;
		}

		[XmlElement("business_product")]
		public InsProduct BusinessProduct
		{
			get;
			set;
		}

		[XmlElement("car")]
		public Car Car
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

		[XmlElement("check_code_type")]
		public string CheckCodeType
		{
			get;
			set;
		}

		[XmlElement("com_id")]
		public string ComId
		{
			get;
			set;
		}

		[XmlElement("com_name")]
		public string ComName
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

		[XmlElement("force_premium")]
		public string ForcePremium
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

		[XmlElement("quote_biz_id")]
		public string QuoteBizId
		{
			get;
			set;
		}

		[XmlElement("quote_error_code")]
		public string QuoteErrorCode
		{
			get;
			set;
		}

		[XmlElement("quote_error_msg")]
		public string QuoteErrorMsg
		{
			get;
			set;
		}

		[XmlElement("real_premium")]
		public string RealPremium
		{
			get;
			set;
		}

		[XmlElement("reduce_premium")]
		public string ReducePremium
		{
			get;
			set;
		}

		[XmlElement("total_premium")]
		public string TotalPremium
		{
			get;
			set;
		}
	}
}
