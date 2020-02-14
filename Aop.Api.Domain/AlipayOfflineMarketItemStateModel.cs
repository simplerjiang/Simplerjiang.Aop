using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketItemStateModel : AopObject
	{
		[XmlElement("audit_rule")]
		public AlipayItemAuditRule AuditRule
		{
			get;
			set;
		}

		[XmlElement("item_id")]
		public string ItemId
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

		[XmlElement("operate_notify_url")]
		public string OperateNotifyUrl
		{
			get;
			set;
		}

		[XmlElement("operation_context")]
		public AlipayItemOperationContext OperationContext
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("state_type")]
		public string StateType
		{
			get;
			set;
		}
	}
}
