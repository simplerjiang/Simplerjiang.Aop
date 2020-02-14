using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserDeviceInfo : AopObject
	{
		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("imei")]
		public string Imei
		{
			get;
			set;
		}

		[XmlElement("ip")]
		public string Ip
		{
			get;
			set;
		}

		[XmlElement("mac")]
		public string Mac
		{
			get;
			set;
		}

		[XmlElement("os_name")]
		public string OsName
		{
			get;
			set;
		}

		[XmlElement("os_version")]
		public string OsVersion
		{
			get;
			set;
		}
	}
}
