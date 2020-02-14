using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskHideDeviceidQueryModel : AopObject
	{
		[XmlElement("app_key_client")]
		public string AppKeyClient
		{
			get;
			set;
		}

		[XmlElement("app_key_server")]
		public string AppKeyServer
		{
			get;
			set;
		}

		[XmlElement("app_name")]
		public string AppName
		{
			get;
			set;
		}

		[XmlElement("deviceid_token")]
		public string DeviceidToken
		{
			get;
			set;
		}
	}
}
