using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppIsvProdmodeCreateResponse : AopResponse
	{
		[XmlElement("process_id")]
		public string ProcessId
		{
			get;
			set;
		}

		[XmlElement("task_id")]
		public string TaskId
		{
			get;
			set;
		}
	}
}
