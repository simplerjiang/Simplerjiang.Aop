using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceExpenseProgressSyncModel : AopObject
	{
		[XmlElement("apply_id")]
		public string ApplyId
		{
			get;
			set;
		}

		[XmlElement("business_time")]
		public string BusinessTime
		{
			get;
			set;
		}

		[XmlElement("expense_detail_url")]
		public string ExpenseDetailUrl
		{
			get;
			set;
		}

		[XmlElement("expense_order_no")]
		public string ExpenseOrderNo
		{
			get;
			set;
		}

		[XmlElement("expense_tax_no")]
		public string ExpenseTaxNo
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

		[XmlElement("invoice_no")]
		public string InvoiceNo
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
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
