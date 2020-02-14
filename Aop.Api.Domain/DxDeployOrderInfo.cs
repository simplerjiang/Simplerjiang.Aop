using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DxDeployOrderInfo : AopObject
	{
		[XmlElement("biz_ns")]
		public string BizNs
		{
			get;
			set;
		}

		[XmlElement("deploy_event_type")]
		public string DeployEventType
		{
			get;
			set;
		}

		[XmlElement("deploy_object_type")]
		public string DeployObjectType
		{
			get;
			set;
		}

		[XmlElement("deploy_payload")]
		public string DeployPayload
		{
			get;
			set;
		}

		[XmlElement("gmt_biz_create")]
		public string GmtBizCreate
		{
			get;
			set;
		}

		[XmlElement("group")]
		public string Group
		{
			get;
			set;
		}

		[XmlElement("pre_record_id")]
		public string PreRecordId
		{
			get;
			set;
		}

		[XmlElement("record_id")]
		public string RecordId
		{
			get;
			set;
		}

		[XmlElement("retry")]
		public bool Retry
		{
			get;
			set;
		}
	}
}
