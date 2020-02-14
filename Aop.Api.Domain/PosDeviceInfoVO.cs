using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PosDeviceInfoVO : AopObject
	{
		[XmlElement("decive_software_name")]
		public string DeciveSoftwareName
		{
			get;
			set;
		}

		[XmlElement("device_app_cnt")]
		public string DeviceAppCnt
		{
			get;
			set;
		}

		[XmlElement("device_app_flow")]
		public string DeviceAppFlow
		{
			get;
			set;
		}

		[XmlElement("device_app_list")]
		public string DeviceAppList
		{
			get;
			set;
		}

		[XmlElement("device_company_name")]
		public string DeviceCompanyName
		{
			get;
			set;
		}

		[XmlElement("device_flow")]
		public string DeviceFlow
		{
			get;
			set;
		}

		[XmlElement("device_ip")]
		public string DeviceIp
		{
			get;
			set;
		}

		[XmlElement("device_mac")]
		public string DeviceMac
		{
			get;
			set;
		}

		[XmlElement("device_os_version")]
		public string DeviceOsVersion
		{
			get;
			set;
		}

		[XmlElement("device_status")]
		public string DeviceStatus
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

		[XmlElement("device_version")]
		public string DeviceVersion
		{
			get;
			set;
		}

		[XmlElement("gmt_activate")]
		public string GmtActivate
		{
			get;
			set;
		}

		[XmlElement("gmt_login")]
		public string GmtLogin
		{
			get;
			set;
		}

		[XmlElement("gmt_production")]
		public string GmtProduction
		{
			get;
			set;
		}

		[XmlElement("gmt_send")]
		public string GmtSend
		{
			get;
			set;
		}

		[XmlElement("gmt_unbundling")]
		public string GmtUnbundling
		{
			get;
			set;
		}

		[XmlElement("gmt_update")]
		public string GmtUpdate
		{
			get;
			set;
		}

		[XmlElement("isv_name")]
		public string IsvName
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

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("sn_no")]
		public string SnNo
		{
			get;
			set;
		}
	}
}
