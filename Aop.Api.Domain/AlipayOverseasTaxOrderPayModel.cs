using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOverseasTaxOrderPayModel : AopObject
	{
		[XmlElement("available_day")]
		public long AvailableDay
		{
			get;
			set;
		}

		[XmlElement("biz_mode")]
		public string BizMode
		{
			get;
			set;
		}

		[XmlElement("company_name")]
		public string CompanyName
		{
			get;
			set;
		}

		[XmlElement("confirm_date")]
		public string ConfirmDate
		{
			get;
			set;
		}

		[XmlElement("country_code")]
		public string CountryCode
		{
			get;
			set;
		}

		[XmlElement("departure_point")]
		public string DeparturePoint
		{
			get;
			set;
		}

		[XmlElement("doc_expire_date")]
		public string DocExpireDate
		{
			get;
			set;
		}

		[XmlElement("doc_id")]
		public string DocId
		{
			get;
			set;
		}

		[XmlElement("extend_param")]
		public string ExtendParam
		{
			get;
			set;
		}

		[XmlElement("identify_account_no")]
		public string IdentifyAccountNo
		{
			get;
			set;
		}

		[XmlElement("identify_account_type")]
		public string IdentifyAccountType
		{
			get;
			set;
		}

		[XmlElement("nationality")]
		public string Nationality
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("passport_name")]
		public string PassportName
		{
			get;
			set;
		}

		[XmlElement("passport_no")]
		public string PassportNo
		{
			get;
			set;
		}

		[XmlElement("sales_amount")]
		public string SalesAmount
		{
			get;
			set;
		}

		[XmlElement("sales_currency")]
		public string SalesCurrency
		{
			get;
			set;
		}

		[XmlElement("sales_date")]
		public string SalesDate
		{
			get;
			set;
		}

		[XmlElement("tax_refund_amount")]
		public string TaxRefundAmount
		{
			get;
			set;
		}

		[XmlElement("tax_refund_currency")]
		public string TaxRefundCurrency
		{
			get;
			set;
		}

		[XmlElement("tax_refund_print_date")]
		public string TaxRefundPrintDate
		{
			get;
			set;
		}

		[XmlElement("tax_refund_scene_type")]
		public string TaxRefundSceneType
		{
			get;
			set;
		}

		[XmlElement("user_received_amount")]
		public string UserReceivedAmount
		{
			get;
			set;
		}

		[XmlElement("user_received_currency")]
		public string UserReceivedCurrency
		{
			get;
			set;
		}
	}
}
