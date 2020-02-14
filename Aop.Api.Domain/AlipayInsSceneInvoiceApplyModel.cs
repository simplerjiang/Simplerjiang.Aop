using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneInvoiceApplyModel : AopObject
	{
		[XmlElement("delivery_type")]
		public string DeliveryType
		{
			get;
			set;
		}

		[XmlElement("invoice_addressee")]
		public InsAddressee InvoiceAddressee
		{
			get;
			set;
		}

		[XmlElement("invoice_apply_item")]
		public InsInvoiceApplyItem InvoiceApplyItem
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

		[XmlElement("invoice_title")]
		public string InvoiceTitle
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

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}
	}
}
