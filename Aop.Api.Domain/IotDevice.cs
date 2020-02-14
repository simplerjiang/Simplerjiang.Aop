using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IotDevice : AopObject
	{
		[XmlElement("bluetooth_mac")]
		public string BluetoothMac
		{
			get;
			set;
		}

		[XmlElement("control_url")]
		public string ControlUrl
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

		[XmlElement("device_name")]
		public string DeviceName
		{
			get;
			set;
		}

		[XmlElement("model_id")]
		public string ModelId
		{
			get;
			set;
		}

		[XmlElement("sn")]
		public string Sn
		{
			get;
			set;
		}

		[XmlElement("wifi_mac")]
		public string WifiMac
		{
			get;
			set;
		}
	}
}
