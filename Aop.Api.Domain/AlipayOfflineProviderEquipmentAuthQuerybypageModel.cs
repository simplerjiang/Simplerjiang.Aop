using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineProviderEquipmentAuthQuerybypageModel : AopObject
	{
		[XmlElement("begin_time")]
		public string BeginTime
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

		[XmlElement("end_time")]
		public string EndTime
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

		[XmlElement("merchant_pid")]
		public string MerchantPid
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public string PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}
	}
}
