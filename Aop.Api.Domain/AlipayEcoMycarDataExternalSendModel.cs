using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarDataExternalSendModel : AopObject
	{
		[XmlElement("external_system_name")]
		public string ExternalSystemName
		{
			get;
			set;
		}

		[XmlElement("is_transfer_uid")]
		public string IsTransferUid
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

		[XmlElement("send_data")]
		public string SendData
		{
			get;
			set;
		}
	}
}
