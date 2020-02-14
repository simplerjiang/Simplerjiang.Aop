using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignQrcodeQueryResponse : AopResponse
	{
		[XmlElement("qrcode_url")]
		public string QrcodeUrl
		{
			get;
			set;
		}
	}
}
