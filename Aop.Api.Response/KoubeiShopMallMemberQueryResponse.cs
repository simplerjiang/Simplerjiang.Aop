using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiShopMallMemberQueryResponse : AopResponse
	{
		[XmlElement("card_level")]
		public string CardLevel
		{
			get;
			set;
		}

		[XmlElement("card_name")]
		public string CardName
		{
			get;
			set;
		}

		[XmlElement("card_point")]
		public string CardPoint
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

		[XmlElement("trade_authed")]
		public bool TradeAuthed
		{
			get;
			set;
		}
	}
}
