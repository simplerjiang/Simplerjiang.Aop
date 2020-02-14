using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MonitorHeartbeatSynResponse : AopResponse
	{
		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}
	}
}
