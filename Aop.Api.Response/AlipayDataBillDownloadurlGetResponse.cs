using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataBillDownloadurlGetResponse : AopResponse
	{
		[XmlElement("bill_download_url")]
		public string BillDownloadUrl
		{
			get;
			set;
		}
	}
}
