using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingCampaignVoucherDetailQueryResponse : AopResponse
	{
		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("voucher")]
		public Voucher Voucher
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
