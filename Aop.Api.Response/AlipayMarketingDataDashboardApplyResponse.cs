using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingDataDashboardApplyResponse : AopResponse
	{
		[XmlArray("dashboard_fail_list")]
		[XmlArrayItem("string")]
		public List<string> DashboardFailList
		{
			get;
			set;
		}

		[XmlElement("status")]
		public bool Status
		{
			get;
			set;
		}
	}
}
