using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceTitleBatchqueryModel : AopObject
	{
		[XmlElement("end_invoice_date")]
		public string EndInvoiceDate
		{
			get;
			set;
		}

		[XmlArray("expense_status_list")]
		[XmlArrayItem("string")]
		public List<string> ExpenseStatusList
		{
			get;
			set;
		}

		[XmlArray("invoice_kind_list")]
		[XmlArrayItem("string")]
		public List<string> InvoiceKindList
		{
			get;
			set;
		}

		[XmlElement("limit_size")]
		public long LimitSize
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public long PageNum
		{
			get;
			set;
		}

		[XmlElement("start_invoice_date")]
		public string StartInvoiceDate
		{
			get;
			set;
		}

		[XmlElement("title_name")]
		public string TitleName
		{
			get;
			set;
		}
	}
}
