using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketingVoucherUseModel : AopObject
	{
		[XmlElement("extend_params")]
		public string ExtendParams
		{
			get;
			set;
		}

		[XmlElement("external_id")]
		public string ExternalId
		{
			get;
			set;
		}

		[XmlElement("external_trade_info")]
		public VoucherUserExternalTradeInfo ExternalTradeInfo
		{
			get;
			set;
		}

		[XmlElement("external_voucher_code")]
		public string ExternalVoucherCode
		{
			get;
			set;
		}
	}
}
