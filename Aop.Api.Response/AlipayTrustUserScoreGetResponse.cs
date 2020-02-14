using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTrustUserScoreGetResponse : AopResponse
	{
		[XmlElement("ali_trust_score")]
		public AliTrustScore AliTrustScore
		{
			get;
			set;
		}
	}
}
