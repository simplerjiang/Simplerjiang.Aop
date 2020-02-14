using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiShopMallMemberIdentifyResponse : AopResponse
	{
		[XmlElement("card_no")]
		public string CardNo
		{
			get;
			set;
		}

		[XmlElement("has_card")]
		public bool HasCard
		{
			get;
			set;
		}
	}
}
