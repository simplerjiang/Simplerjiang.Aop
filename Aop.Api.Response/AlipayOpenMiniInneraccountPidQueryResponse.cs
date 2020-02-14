using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniInneraccountPidQueryResponse : AopResponse
	{
		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}
	}
}
