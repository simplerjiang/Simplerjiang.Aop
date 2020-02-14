using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class VoucherModifyInfo : AopObject
	{
		[XmlArray("suitable_shops")]
		[XmlArrayItem("string")]
		public List<string> SuitableShops
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

		[XmlElement("voucher_id")]
		public string VoucherId
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
	}
}
