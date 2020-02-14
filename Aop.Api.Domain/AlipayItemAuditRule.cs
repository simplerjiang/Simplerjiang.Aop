using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayItemAuditRule : AopObject
	{
		[XmlElement("audit_type")]
		public string AuditType
		{
			get;
			set;
		}

		[XmlElement("need_audit")]
		public bool NeedAudit
		{
			get;
			set;
		}
	}
}
