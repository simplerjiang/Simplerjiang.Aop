using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppInvoiceApplyResultSyncModel : AopObject
	{
		[XmlElement("apply_id")]
		public string ApplyId
		{
			get;
			set;
		}

		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("result_msg")]
		public string ResultMsg
		{
			get;
			set;
		}

		[XmlElement("tax_apply_id")]
		public string TaxApplyId
		{
			get;
			set;
		}
	}
}
