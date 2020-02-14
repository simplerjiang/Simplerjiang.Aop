using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ActivityAuditDTO : AopObject
	{
		[XmlElement("audit_id")]
		public string AuditId
		{
			get;
			set;
		}

		[XmlElement("audit_status")]
		public string AuditStatus
		{
			get;
			set;
		}

		[XmlElement("creator_id")]
		public string CreatorId
		{
			get;
			set;
		}

		[XmlElement("creator_type")]
		public string CreatorType
		{
			get;
			set;
		}

		[XmlElement("operation_time")]
		public string OperationTime
		{
			get;
			set;
		}

		[XmlElement("reason")]
		public string Reason
		{
			get;
			set;
		}
	}
}
