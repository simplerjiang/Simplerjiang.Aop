using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceInfoSendModel : AopObject
	{
		[XmlArray("invoice_info_list")]
		[XmlArrayItem("invoice_send_open_model")]
		public List<InvoiceSendOpenModel> InvoiceInfoList
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
