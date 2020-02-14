using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditEpEntityMonitorSetResponse : AopResponse
	{
		[XmlElement("biz_success")]
		public bool BizSuccess
		{
			get;
			set;
		}
	}
}
