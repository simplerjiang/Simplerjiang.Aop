using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserInfoVerifyResponse : AopResponse
	{
		[XmlElement("match_result")]
		public string MatchResult
		{
			get;
			set;
		}
	}
}
