using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataActivityBillDownloadResponse : AopResponse
	{
		[XmlElement("url")]
		public string Url
		{
			get;
			set;
		}
	}
}
