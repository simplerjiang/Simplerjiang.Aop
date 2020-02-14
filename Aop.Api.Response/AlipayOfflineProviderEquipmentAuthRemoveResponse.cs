using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineProviderEquipmentAuthRemoveResponse : AopResponse
	{
		[XmlElement("device_id")]
		public string DeviceId
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
	}
}
