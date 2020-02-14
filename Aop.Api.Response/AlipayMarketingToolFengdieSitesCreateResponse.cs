using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieSitesCreateResponse : AopResponse
	{
		[XmlElement("data")]
		public FengdieActivityCreateModel Data
		{
			get;
			set;
		}
	}
}
