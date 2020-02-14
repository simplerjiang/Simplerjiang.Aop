using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingAdvertisingModifyResponse : AopResponse
	{
		[XmlElement("ad_id")]
		public string AdId
		{
			get;
			set;
		}
	}
}
