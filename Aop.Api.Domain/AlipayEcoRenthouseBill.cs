using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseBill : AopObject
	{
		[XmlElement("bill_amount")]
		public string BillAmount
		{
			get;
			set;
		}

		[XmlElement("bill_create_time")]
		public string BillCreateTime
		{
			get;
			set;
		}

		[XmlElement("bill_desc")]
		public string BillDesc
		{
			get;
			set;
		}

		[XmlElement("bill_no")]
		public string BillNo
		{
			get;
			set;
		}

		[XmlElement("bill_status")]
		public long BillStatus
		{
			get;
			set;
		}

		[XmlElement("bill_type")]
		public string BillType
		{
			get;
			set;
		}

		[XmlElement("deadline_date")]
		public string DeadlineDate
		{
			get;
			set;
		}

		[XmlElement("deduction_amount")]
		public string DeductionAmount
		{
			get;
			set;
		}

		[XmlElement("discount_amount")]
		public string DiscountAmount
		{
			get;
			set;
		}

		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}

		[XmlElement("lease_no")]
		public string LeaseNo
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

		[XmlElement("min_pay_amount")]
		public string MinPayAmount
		{
			get;
			set;
		}

		[XmlElement("paid_amount")]
		public string PaidAmount
		{
			get;
			set;
		}

		[XmlElement("pay_lock")]
		public long PayLock
		{
			get;
			set;
		}

		[XmlElement("pay_lock_memo")]
		public string PayLockMemo
		{
			get;
			set;
		}

		[XmlElement("pay_status")]
		public long PayStatus
		{
			get;
			set;
		}

		[XmlElement("pay_time")]
		public string PayTime
		{
			get;
			set;
		}

		[XmlElement("start_date")]
		public string StartDate
		{
			get;
			set;
		}
	}
}
