using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceElementModel : AopObject
	{
		[XmlElement("expense_status")]
		public string ExpenseStatus
		{
			get;
			set;
		}

		[XmlElement("has_pdf_file")]
		public bool HasPdfFile
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

		[XmlElement("invoice_kind")]
		public string InvoiceKind
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

		[XmlElement("payee_name")]
		public string PayeeName
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

		[XmlElement("payer_name")]
		public string PayerName
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
	}
}
