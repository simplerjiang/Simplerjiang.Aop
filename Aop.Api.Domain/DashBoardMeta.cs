using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DashBoardMeta : AopObject
	{
		[XmlElement("auth_status")]
		public bool AuthStatus
		{
			get;
			set;
		}

		[XmlElement("create_time")]
		public string CreateTime
		{
			get;
			set;
		}

		[XmlElement("dashboard_id")]
		public string DashboardId
		{
			get;
			set;
		}

		[XmlElement("dashboard_name")]
		public string DashboardName
		{
			get;
			set;
		}
	}
}
