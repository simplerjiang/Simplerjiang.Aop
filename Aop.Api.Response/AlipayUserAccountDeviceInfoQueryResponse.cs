using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAccountDeviceInfoQueryResponse : AopResponse
	{
		[XmlArray("device_infos")]
		[XmlArrayItem("device_result_info")]
		public List<DeviceResultInfo> DeviceInfos
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

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}
	}
}
