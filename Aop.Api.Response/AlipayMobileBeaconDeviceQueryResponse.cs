using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileBeaconDeviceQueryResponse : AopResponse
	{
		[XmlElement("beacon_device_info")]
		public BeaconDeviceInfo BeaconDeviceInfo
		{
			get;
			set;
		}

		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("msg")]
		public new string Msg
		{
			get;
			set;
		}
	}
}
