using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMerchantDeviceHeartbeatUploadModel : AopObject
	{
		[XmlElement("app_info")]
		public string AppInfo
		{
			get;
			set;
		}

		[XmlElement("exception_info")]
		public string ExceptionInfo
		{
			get;
			set;
		}

		[XmlElement("extend_info")]
		public string ExtendInfo
		{
			get;
			set;
		}

		[XmlElement("hardware_version")]
		public string HardwareVersion
		{
			get;
			set;
		}

		[XmlElement("isv_app_id")]
		public string IsvAppId
		{
			get;
			set;
		}

		[XmlElement("isv_pid")]
		public string IsvPid
		{
			get;
			set;
		}

		[XmlElement("isv_server_time")]
		public string IsvServerTime
		{
			get;
			set;
		}

		[XmlElement("lbs")]
		public string Lbs
		{
			get;
			set;
		}

		[XmlElement("lbs_type")]
		public string LbsType
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

		[XmlElement("manufacturer")]
		public string Manufacturer
		{
			get;
			set;
		}

		[XmlElement("network_ip")]
		public string NetworkIp
		{
			get;
			set;
		}

		[XmlElement("network_name")]
		public string NetworkName
		{
			get;
			set;
		}

		[XmlElement("network_type")]
		public string NetworkType
		{
			get;
			set;
		}

		[XmlElement("product")]
		public string Product
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("sn_id")]
		public string SnId
		{
			get;
			set;
		}

		[XmlElement("soft_version")]
		public string SoftVersion
		{
			get;
			set;
		}

		[XmlElement("sys_type")]
		public string SysType
		{
			get;
			set;
		}

		[XmlElement("sys_version")]
		public string SysVersion
		{
			get;
			set;
		}

		[XmlElement("time")]
		public string Time
		{
			get;
			set;
		}
	}
}
