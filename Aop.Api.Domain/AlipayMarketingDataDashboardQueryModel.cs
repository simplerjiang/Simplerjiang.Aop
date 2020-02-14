using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingDataDashboardQueryModel : AopObject
	{
		[XmlElement("dashboard_id")]
		public string DashboardId
		{
			get;
			set;
		}

		[XmlArray("param")]
		[XmlArrayItem("dashboard_param")]
		public List<DashboardParam> Param
		{
			get;
			set;
		}
	}
}
