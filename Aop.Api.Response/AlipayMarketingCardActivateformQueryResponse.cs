using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardActivateformQueryResponse : AopResponse
	{
		[XmlElement("infos")]
		public string Infos
		{
			get;
			set;
		}
	}
}
