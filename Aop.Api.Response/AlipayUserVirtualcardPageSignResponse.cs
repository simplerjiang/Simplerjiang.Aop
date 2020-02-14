using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserVirtualcardPageSignResponse : AopResponse
	{
		[XmlElement("card_no")]
		public string CardNo
		{
			get;
			set;
		}

		[XmlElement("card_type")]
		public string CardType
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
