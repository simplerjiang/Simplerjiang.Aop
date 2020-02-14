using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceDetailOutputQueryResponse : AopResponse
	{
		[XmlElement("anti_fake_code")]
		public string AntiFakeCode
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

		[XmlElement("expense_status")]
		public string ExpenseStatus
		{
			get;
			set;
		}

		[XmlElement("has_risk")]
		public bool HasRisk
		{
			get;
			set;
		}

		[XmlElement("has_upload_pdf")]
		public string HasUploadPdf
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

		[XmlElement("invoice_code")]
		public string InvoiceCode
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

		[XmlElement("invoice_img_url")]
		public string InvoiceImgUrl
		{
			get;
			set;
		}

		[XmlArray("invoice_item_content_list")]
		[XmlArrayItem("invoice_item_content")]
		public List<InvoiceItemContent> InvoiceItemContentList
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

		[XmlElement("invoice_status")]
		public string InvoiceStatus
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

		[XmlElement("payee_phone")]
		public string PayeePhone
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

		[XmlElement("payee_tax_no")]
		public string PayeeTaxNo
		{
			get;
			set;
		}

		[XmlElement("payer_address")]
		public string PayerAddress
		{
			get;
			set;
		}

		[XmlElement("payer_bank_account")]
		public string PayerBankAccount
		{
			get;
			set;
		}

		[XmlElement("payer_bank_name")]
		public string PayerBankName
		{
			get;
			set;
		}

		[XmlElement("payer_name")]
		public string PayerName
		{
			get;
			set;
		}

		[XmlElement("payer_phone")]
		public string PayerPhone
		{
			get;
			set;
		}

		[XmlElement("payer_tax_no")]
		public string PayerTaxNo
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

		[XmlElement("tax_type")]
		public string TaxType
		{
			get;
			set;
		}
	}
}
