using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingVoucherQueryModel : AopObject
	{
		[XmlElement("voucher_id")]
		public string VoucherId
		{
			get;
			set;
		}
	}
}
