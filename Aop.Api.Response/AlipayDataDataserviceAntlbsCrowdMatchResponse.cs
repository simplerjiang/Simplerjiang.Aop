using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceAntlbsCrowdMatchResponse : AopResponse
	{
		[XmlArray("match_result")]
		[XmlArrayItem("promox_crowd_match_model")]
		public List<PromoxCrowdMatchModel> MatchResult
		{
			get;
			set;
		}
	}
}
