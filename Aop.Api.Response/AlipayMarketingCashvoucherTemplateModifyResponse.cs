using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCashvoucherTemplateModifyResponse : AopResponse
	{
		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
