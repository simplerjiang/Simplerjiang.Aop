using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantDeviceHeartbeatUploadResponse : AopResponse
	{
		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_msg")]
		public string ErrorMsg
		{
			get;
			set;
		}

		[XmlElement("retry")]
		public bool Retry
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
