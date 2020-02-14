using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceApplyModel : AopObject
	{
		[XmlElement("action")]
		public string Action
		{
			get;
			set;
		}

		[XmlElement("apply_from")]
		public string ApplyFrom
		{
			get;
			set;
		}

		[XmlElement("invoice_apply_model")]
		public InvoiceApplyOpenModel InvoiceApplyModel
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
