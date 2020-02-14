using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertAdvResponse : AopObject
	{
		[XmlElement("adv_id")]
		public string AdvId
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("single_voucher")]
		public KbAdvertAdvSingleVoucherResponse SingleVoucher
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
