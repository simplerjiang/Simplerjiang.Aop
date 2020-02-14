using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardBenefitModifyResponse : AopResponse
	{
		[XmlElement("result")]
		public bool Result
		{
			get;
			set;
		}
	}
}
