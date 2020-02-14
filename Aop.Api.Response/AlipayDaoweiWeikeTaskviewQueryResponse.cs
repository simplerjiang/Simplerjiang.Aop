using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDaoweiWeikeTaskviewQueryResponse : AopResponse
	{
		[XmlArray("task_views")]
		[XmlArrayItem("weike_task_view")]
		public List<WeikeTaskView> TaskViews
		{
			get;
			set;
		}
	}
}
