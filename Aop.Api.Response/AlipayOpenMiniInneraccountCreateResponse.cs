using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenMiniInneraccountCreateResponse : AopResponse
	{
		[XmlElement("pid")]
		public string Pid
		{
			get;
			set;
		}
	}
}
