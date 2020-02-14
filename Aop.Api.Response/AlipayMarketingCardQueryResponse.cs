using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingCardQueryResponse : AopResponse
	{
		[XmlElement("card_info")]
		public MerchantCard CardInfo
		{
			get;
			set;
		}

		[XmlElement("schema_url")]
		public string SchemaUrl
		{
			get;
			set;
		}
	}
}
