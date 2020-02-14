using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCampaignSubcertQueryModel : AopObject
	{
		[XmlElement("login_id")]
		public string LoginId
		{
			get;
			set;
		}

		[XmlElement("lot_num")]
		public string LotNum
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
