using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniInnerversionOnlineModel : AopObject
	{
		[XmlElement("app_offline_version")]
		public string AppOfflineVersion
		{
			get;
			set;
		}

		[XmlElement("app_online_version")]
		public string AppOnlineVersion
		{
			get;
			set;
		}

		[XmlElement("mini_app_id")]
		public string MiniAppId
		{
			get;
			set;
		}
	}
}
