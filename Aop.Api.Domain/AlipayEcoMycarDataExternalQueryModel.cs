using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarDataExternalQueryModel : AopObject
	{
		[XmlElement("external_system_name")]
		public string ExternalSystemName
		{
			get;
			set;
		}

		[XmlElement("is_transfer_uid")]
		public bool IsTransferUid
		{
			get;
			set;
		}

		[XmlElement("operate_type")]
		public string OperateType
		{
			get;
			set;
		}

		[XmlElement("query_condition")]
		public string QueryCondition
		{
			get;
			set;
		}
	}
}
