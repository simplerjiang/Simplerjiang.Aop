using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InteligentPromoTool : AopObject
	{
		[XmlElement("inteligent_send_rule")]
		public InteligentSendRule InteligentSendRule
		{
			get;
			set;
		}

		[XmlElement("inteligent_voucher")]
		public InteligentVoucher InteligentVoucher
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("voucher_no")]
		public string VoucherNo
		{
			get;
			set;
		}
	}
}
