using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiAdvertDeliveryItemApplyResponse : AopResponse
	{
		[XmlElement("benefit_detail")]
		public string BenefitDetail
		{
			get;
			set;
		}

		[XmlElement("benefit_id")]
		public string BenefitId
		{
			get;
			set;
		}
	}
}
