using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingToolPrizesendAuthModel : AopObject
	{
		[XmlElement("prize_id")]
		public string PrizeId
		{
			get;
			set;
		}

		[XmlElement("req_id")]
		public string ReqId
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
