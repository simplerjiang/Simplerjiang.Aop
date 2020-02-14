using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceSendOpenModel : AopObject
	{
		[XmlElement("apply_id")]
		public string ApplyId
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

		[XmlElement("ex_tax_amount")]
		public string ExTaxAmount
		{
			get;
			set;
		}

		[XmlElement("extend_fields")]
		public string ExtendFields
		{
			get;
			set;
		}

		[XmlElement("file_download_type")]
		public string FileDownloadType
		{
			get;
			set;
		}

		[XmlElement("file_download_url")]
		public string FileDownloadUrl
		{
			get;
			set;
		}

		[XmlElement("invoice_code")]
		public string InvoiceCode
		{
			get;
			set;
		}

		[XmlArray("invoice_content")]
		[XmlArrayItem("invoice_item_open_model")]
		public List<InvoiceItemOpenModel> InvoiceContent
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

		[XmlElement("invoice_no")]
		public string InvoiceNo
		{
			get;
			set;
		}

		[XmlElement("invoice_title")]
		public InvoiceTitleOpenModel InvoiceTitle
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

		[XmlElement("out_invoice_id")]
		public string OutInvoiceId
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

		[XmlElement("payee_address_tel")]
		public string PayeeAddressTel
		{
			get;
			set;
		}

		[XmlElement("payee_bank_name_account")]
		public string PayeeBankNameAccount
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

		[XmlElement("sum_amount")]
		public string SumAmount
		{
			get;
			set;
		}

		[XmlElement("tax_amount")]
		public string TaxAmount
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
