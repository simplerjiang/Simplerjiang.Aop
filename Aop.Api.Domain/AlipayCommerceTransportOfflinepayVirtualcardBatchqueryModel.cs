using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceTransportOfflinepayVirtualcardBatchqueryModel : AopObject
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
