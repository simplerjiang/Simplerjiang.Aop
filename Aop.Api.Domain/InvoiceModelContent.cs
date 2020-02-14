using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InvoiceModelContent : AopObject
	{
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

		[XmlArray("invoice_content")]
		[XmlArrayItem("invoice_item_content")]
		public List<InvoiceItemContent> InvoiceContent
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

		[XmlElement("invoice_fake_code")]
		public string InvoiceFakeCode
		{
			get;
			set;
		}

		[XmlElement("invoice_file_data")]
		public string InvoiceFileData
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

		[XmlElement("invoice_no")]
		public string InvoiceNo
		{
			get;
			set;
		}

		[XmlElement("invoice_operator")]
		public string InvoiceOperator
		{
			get;
			set;
		}

		[XmlElement("invoice_title")]
		public InvoiceTitleModel InvoiceTitle
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

		[XmlElement("original_blue_invoice_code")]
		public string OriginalBlueInvoiceCode
		{
			get;
			set;
		}

		[XmlElement("original_blue_invoice_no")]
		public string OriginalBlueInvoiceNo
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
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

		[XmlElement("register_address")]
		public string RegisterAddress
		{
			get;
			set;
		}

		[XmlElement("register_bank_account")]
		public string RegisterBankAccount
		{
			get;
			set;
		}

		[XmlElement("register_bank_name")]
		public string RegisterBankName
		{
			get;
			set;
		}

		[XmlElement("register_name")]
		public string RegisterName
		{
			get;
			set;
		}

		[XmlElement("register_no")]
		public string RegisterNo
		{
			get;
			set;
		}

		[XmlElement("register_phone_no")]
		public string RegisterPhoneNo
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

		[XmlElement("tax_type")]
		public string TaxType
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
