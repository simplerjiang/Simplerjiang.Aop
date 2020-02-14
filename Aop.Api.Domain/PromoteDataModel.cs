using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PromoteDataModel : AopObject
	{
		[XmlElement("checked_voucher_num")]
		public long CheckedVoucherNum
		{
			get;
			set;
		}

		[XmlElement("claim_voucher_num")]
		public long ClaimVoucherNum
		{
			get;
			set;
		}

		[XmlElement("commission_amount")]
		public string CommissionAmount
		{
			get;
			set;
		}
	}
}
