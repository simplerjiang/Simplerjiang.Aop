using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundTransThirdpartyRewardQueryModel : AopObject
	{
		[XmlElement("scene")]
		public string Scene
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

		[XmlElement("transfer_no")]
		public string TransferNo
		{
			get;
			set;
		}
	}
}
