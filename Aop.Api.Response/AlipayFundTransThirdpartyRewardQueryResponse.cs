using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransThirdpartyRewardQueryResponse : AopResponse
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("error_msg")]
		public string ErrorMsg
		{
			get;
			set;
		}

		[XmlElement("last_modified")]
		public string LastModified
		{
			get;
			set;
		}

		[XmlElement("receiver_user_id")]
		public string ReceiverUserId
		{
			get;
			set;
		}

		[XmlElement("sender_user_id")]
		public string SenderUserId
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("transfer_no")]
		public string TransferNo
		{
			get;
			set;
		}
	}
}
