using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignVoucherDetailQueryModel : AopObject
	{
		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}

		[XmlElement("voucher_id")]
		public string VoucherId
		{
			get;
			set;
		}
	}
}
