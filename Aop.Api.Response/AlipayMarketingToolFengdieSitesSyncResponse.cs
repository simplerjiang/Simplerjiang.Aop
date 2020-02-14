using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingToolFengdieSitesSyncResponse : AopResponse
	{
		[XmlElement("data")]
		public FengdieSuccessRespModel Data
		{
			get;
			set;
		}
	}
}
