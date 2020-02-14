using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayZmscoreZrankGetResponse : AopResponse
	{
		[XmlElement("zm_score_zrank")]
		public AlipayZmScoreZrankResult ZmScoreZrank
		{
			get;
			set;
		}
	}
}
