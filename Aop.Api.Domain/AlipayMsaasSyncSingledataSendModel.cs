using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMsaasSyncSingledataSendModel : AopObject
	{
		[XmlElement("app_max_version")]
		public string AppMaxVersion
		{
			get;
			set;
		}

		[XmlElement("app_min_version")]
		public string AppMinVersion
		{
			get;
			set;
		}

		[XmlElement("binary_payload")]
		public string BinaryPayload
		{
			get;
			set;
		}

		[XmlElement("biz_tag")]
		public string BizTag
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("client_app")]
		public string ClientApp
		{
			get;
			set;
		}

		[XmlElement("device_id")]
		public string DeviceId
		{
			get;
			set;
		}

		[XmlElement("immediate_sync")]
		public bool ImmediateSync
		{
			get;
			set;
		}

		[XmlElement("link_token")]
		public string LinkToken
		{
			get;
			set;
		}

		[XmlElement("os_type")]
		public string OsType
		{
			get;
			set;
		}

		[XmlElement("payload")]
		public string Payload
		{
			get;
			set;
		}

		[XmlElement("third_msg_id")]
		public string ThirdMsgId
		{
			get;
			set;
		}

		[XmlElement("valid_end")]
		public string ValidEnd
		{
			get;
			set;
		}

		[XmlElement("valid_start")]
		public string ValidStart
		{
			get;
			set;
		}
	}
}
