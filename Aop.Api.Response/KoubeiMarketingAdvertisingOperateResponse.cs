using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingAdvertisingOperateResponse : AopResponse
	{
		[XmlElement("ad_id")]
		public string AdId
		{
			get;
			set;
		}
	}
}
