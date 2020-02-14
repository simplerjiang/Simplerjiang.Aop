using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntfortuneMarketingCrowdWshopMatchResponse : AopResponse
	{
		[XmlElement("match_result")]
		public bool MatchResult
		{
			get;
			set;
		}
	}
}
