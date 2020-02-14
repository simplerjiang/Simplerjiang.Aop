using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingMallTradeBindResponse : AopResponse
	{
		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}
	}
}
