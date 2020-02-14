using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class VoucherInfo : AopObject
	{
		[XmlElement("can_give_friend")]
		public bool CanGiveFriend
		{
			get;
			set;
		}

		[XmlElement("use_rule")]
		public UseRuleInfo UseRule
		{
			get;
			set;
		}

		[XmlElement("valid_date")]
		public ValidDateInfo ValidDate
		{
			get;
			set;
		}

		[XmlElement("voucher_desc")]
		public string VoucherDesc
		{
			get;
			set;
		}

		[XmlElement("voucher_img")]
		public string VoucherImg
		{
			get;
			set;
		}

		[XmlElement("voucher_logo")]
		public string VoucherLogo
		{
			get;
			set;
		}

		[XmlElement("voucher_name")]
		public string VoucherName
		{
			get;
			set;
		}

		[XmlArray("voucher_terms")]
		[XmlArrayItem("voucher_term_info")]
		public List<VoucherTermInfo> VoucherTerms
		{
			get;
			set;
		}

		[XmlElement("voucher_type")]
		public string VoucherType
		{
			get;
			set;
		}
	}
}
