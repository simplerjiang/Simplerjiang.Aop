using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditEpEntityMonitorUploadResponse : AopResponse
	{
		[XmlElement("biz_success")]
		public bool BizSuccess
		{
			get;
			set;
		}

		[XmlElement("solution_id")]
		public string SolutionId
		{
			get;
			set;
		}
	}
}
