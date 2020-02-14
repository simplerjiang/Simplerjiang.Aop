using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserCustomerIdentifyModel : AopObject
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("device_info")]
		public AlipayUserDeviceInfo DeviceInfo
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("principal")]
		public AlipayUserPrincipalInfo Principal
		{
			get;
			set;
		}
	}
}
