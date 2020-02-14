using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserUnicomCardInfoSyncResponse : AopResponse
	{
		[XmlElement("card_sync_result")]
		public string CardSyncResult
		{
			get;
			set;
		}

		[XmlElement("phone_no")]
		public string PhoneNo
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
