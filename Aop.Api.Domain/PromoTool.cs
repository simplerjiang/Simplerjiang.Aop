using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PromoTool : AopObject
	{
		[XmlElement("point_card")]
		public PointCard PointCard
		{
			get;
			set;
		}

		[XmlElement("send_rule")]
		public SendRule SendRule
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

		[XmlElement("voucher")]
		public Voucher Voucher
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
