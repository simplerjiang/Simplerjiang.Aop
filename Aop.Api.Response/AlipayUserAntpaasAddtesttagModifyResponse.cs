using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAntpaasAddtesttagModifyResponse : AopResponse
	{
		[XmlElement("result")]
		public string Result
		{
			get;
			set;
		}
	}
}
