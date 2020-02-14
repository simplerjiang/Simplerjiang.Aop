using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardBenefitDeleteResponse : AopResponse
	{
		[XmlElement("result")]
		public bool Result
		{
			get;
			set;
		}
	}
}
