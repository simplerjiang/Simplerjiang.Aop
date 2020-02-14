using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCampaignCertCreateResponse : AopResponse
	{
		[XmlElement("lot_number")]
		public string LotNumber
		{
			get;
			set;
		}
	}
}
