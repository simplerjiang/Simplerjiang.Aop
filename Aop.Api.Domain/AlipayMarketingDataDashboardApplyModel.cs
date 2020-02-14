using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingDataDashboardApplyModel : AopObject
	{
		[XmlArray("dashboard_ids")]
		[XmlArrayItem("string")]
		public List<string> DashboardIds
		{
			get;
			set;
		}
	}
}
