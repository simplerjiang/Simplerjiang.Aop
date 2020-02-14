using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardConsumeSyncResponse : AopResponse
	{
		[XmlElement("external_card_no")]
		public string ExternalCardNo
		{
			get;
			set;
		}
	}
}
