using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse : AopResponse
	{
		[XmlElement("userid")]
		public string Userid
		{
			get;
			set;
		}
	}
}
