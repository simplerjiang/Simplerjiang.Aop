using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SceneProdBillDetail : AopObject
	{
		[XmlElement("bill_type")]
		public string BillType
		{
			get;
			set;
		}

		[XmlElement("due_date")]
		public string DueDate
		{
			get;
			set;
		}

		[XmlElement("int_amt")]
		public string IntAmt
		{
			get;
			set;
		}

		[XmlElement("overdue_days")]
		public string OverdueDays
		{
			get;
			set;
		}

		[XmlElement("pen_amt")]
		public string PenAmt
		{
			get;
			set;
		}

		[XmlElement("prin_amt")]
		public string PrinAmt
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
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

		[XmlElement("term")]
		public string Term
		{
			get;
			set;
		}

		[XmlElement("total_amt")]
		public string TotalAmt
		{
			get;
			set;
		}
	}
}
