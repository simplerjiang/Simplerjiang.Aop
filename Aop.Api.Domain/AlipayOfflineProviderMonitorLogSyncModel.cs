using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineProviderMonitorLogSyncModel : AopObject
	{
		[XmlArray("logs")]
		[XmlArrayItem("i_s_v_log_sync")]
		public List<ISVLogSync> Logs
		{
			get;
			set;
		}
	}
}
