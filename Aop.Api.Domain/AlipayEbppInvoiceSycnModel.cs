using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceSycnModel : AopObject
	{
		[XmlArray("invoice_info")]
		[XmlArrayItem("invoice_model_content")]
		public List<InvoiceModelContent> InvoiceInfo
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

		[XmlElement("sub_m_short_name")]
		public string SubMShortName
		{
			get;
			set;
		}
	}
}
