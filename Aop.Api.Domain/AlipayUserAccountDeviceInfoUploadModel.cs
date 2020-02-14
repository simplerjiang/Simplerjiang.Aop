using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserAccountDeviceInfoUploadModel : AopObject
	{
		[XmlElement("call_back")]
		public string CallBack
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

		[XmlElement("device_type")]
		public string DeviceType
		{
			get;
			set;
		}

		[XmlElement("encrypt_type")]
		public string EncryptType
		{
			get;
			set;
		}

		[XmlElement("extra_info")]
		public string ExtraInfo
		{
			get;
			set;
		}

		[XmlElement("params")]
		public string Params
		{
			get;
			set;
		}

		[XmlElement("request_from")]
		public string RequestFrom
		{
			get;
			set;
		}
	}
}
