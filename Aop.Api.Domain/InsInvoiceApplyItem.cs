using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsInvoiceApplyItem : AopObject
	{
		[XmlElement("apply_scope")]
		public string ApplyScope
		{
			get;
			set;
		}

		[XmlElement("expense_type")]
		public string ExpenseType
		{
			get;
			set;
		}

		[XmlElement("ins_biz_no")]
		public string InsBizNo
		{
			get;
			set;
		}

		[XmlElement("ins_biz_type")]
		public string InsBizType
		{
			get;
			set;
		}
	}
}
