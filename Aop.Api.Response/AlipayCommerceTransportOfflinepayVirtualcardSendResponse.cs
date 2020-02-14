using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceTransportOfflinepayVirtualcardSendResponse : AopResponse
	{
		[XmlElement("card_no")]
		public string CardNo
		{
			get;
			set;
		}

		[XmlElement("card_schema")]
		public string CardSchema
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

		[XmlElement("error_message")]
		public string ErrorMessage
		{
			get;
			set;
		}

		[XmlElement("sub_error_code")]
		public string SubErrorCode
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
