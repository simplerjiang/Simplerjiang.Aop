using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EcoApplySchedule : AopObject
	{
		[XmlElement("audit_comment")]
		public string AuditComment
		{
			get;
			set;
		}

		[XmlElement("audit_time")]
		public string AuditTime
		{
			get;
			set;
		}

		[XmlElement("edit_flag")]
		public long EditFlag
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("order_num")]
		public long OrderNum
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

		[XmlElement("status_desc")]
		public string StatusDesc
		{
			get;
			set;
		}

		[XmlElement("step")]
		public string Step
		{
			get;
			set;
		}

		[XmlElement("step_desc")]
		public string StepDesc
		{
			get;
			set;
		}
	}
}
