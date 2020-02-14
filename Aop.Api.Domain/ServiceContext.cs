using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ServiceContext : AopObject
	{
		[XmlElement("client_ip")]
		public string ClientIp
		{
			get;
			set;
		}

		[XmlElement("client_pcidguid")]
		public string ClientPcidguid
		{
			get;
			set;
		}

		[XmlElement("server_name")]
		public string ServerName
		{
			get;
			set;
		}

		[XmlElement("session_id")]
		public string SessionId
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
