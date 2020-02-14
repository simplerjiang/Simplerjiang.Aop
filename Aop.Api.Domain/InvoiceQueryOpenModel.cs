using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceQueryOpenModel : AopObject
	{
		[XmlElement("apply_from")]
		public string ApplyFrom
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

		[XmlElement("checker")]
		public string Checker
		{
			get;
			set;
		}

		[XmlElement("clerk")]
		public string Clerk
		{
			get;
			set;
		}

		[XmlElement("einv_code")]
		public string EinvCode
		{
			get;
			set;
		}

		[XmlElement("einv_no")]
		public string EinvNo
		{
			get;
			set;
		}

		[XmlElement("ex_tax_amount")]
		public string ExTaxAmount
		{
			get;
			set;
		}

		[XmlElement("invoice_amount")]
		public string InvoiceAmount
		{
			get;
			set;
		}

		[XmlArray("invoice_content")]
		[XmlArrayItem("invoice_item_query_open_model")]
		public List<InvoiceItemQueryOpenModel> InvoiceContent
		{
			get;
			set;
		}

		[XmlElement("invoice_date")]
		public string InvoiceDate
		{
			get;
			set;
		}

		[XmlElement("invoice_id")]
		public string InvoiceId
		{
			get;
			set;
		}

		[XmlElement("invoice_kind")]
		public string InvoiceKind
		{
			get;
			set;
		}

		[XmlElement("invoice_memo")]
		public string InvoiceMemo
		{
			get;
			set;
		}

		[XmlElement("invoice_title")]
		public InvoiceTitleQueryOpenModel InvoiceTitle
		{
			get;
			set;
		}

		[XmlElement("invoice_type")]
		public string InvoiceType
		{
			get;
			set;
		}

		[XmlElement("m_short_name")]
		public string MShortName
		{
			get;
			set;
		}

		[XmlElement("ori_blue_inv_code")]
		public string OriBlueInvCode
		{
			get;
			set;
		}

		[XmlElement("ori_blue_inv_no")]
		public string OriBlueInvNo
		{
			get;
			set;
		}

		[XmlElement("out_apply_id")]
		public string OutApplyId
		{
			get;
			set;
		}

		[XmlElement("out_trade_no")]
		public string OutTradeNo
		{
			get;
			set;
		}

		[XmlElement("payee")]
		public string Payee
		{
			get;
			set;
		}

		[XmlElement("payee_address")]
		public string PayeeAddress
		{
			get;
			set;
		}

		[XmlElement("payee_bank_account")]
		public string PayeeBankAccount
		{
			get;
			set;
		}

		[XmlElement("payee_bank_name")]
		public string PayeeBankName
		{
			get;
			set;
		}

		[XmlElement("payee_register_name")]
		public string PayeeRegisterName
		{
			get;
			set;
		}

		[XmlElement("payee_register_no")]
		public string PayeeRegisterNo
		{
			get;
			set;
		}

		[XmlElement("payee_tel")]
		public string PayeeTel
		{
			get;
			set;
		}

		[XmlElement("preview_image_url")]
		public string PreviewImageUrl
		{
			get;
			set;
		}

		[XmlElement("sub_m_short_name")]
		public string SubMShortName
		{
			get;
			set;
		}

		[XmlElement("sum_tax_amount")]
		public string SumTaxAmount
		{
			get;
			set;
		}

		[XmlElement("trade_date")]
		public string TradeDate
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
