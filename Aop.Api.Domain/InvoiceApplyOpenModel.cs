using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceApplyOpenModel : AopObject
	{
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
		[XmlArrayItem("invoice_item_apply_open_model")]
		public List<InvoiceItemApplyOpenModel> InvoiceContent
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
		public InvoiceTitleApplyOpenModel InvoiceTitle
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

		[XmlElement("payer_contact_email")]
		public string PayerContactEmail
		{
			get;
			set;
		}

		[XmlElement("payer_contact_mobile")]
		public string PayerContactMobile
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

		[XmlElement("tax_token")]
		public string TaxToken
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
	}
}
