using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingVoucherListQueryResponse : AopResponse
	{
		[XmlArray("vouchers")]
		[XmlArrayItem("voucher_lite_info")]
		public List<VoucherLiteInfo> Vouchers
		{
			get;
			set;
		}
	}
}
