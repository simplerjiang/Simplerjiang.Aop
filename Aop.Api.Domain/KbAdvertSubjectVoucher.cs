using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbAdvertSubjectVoucher : AopObject
	{
		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}

		[XmlArray("city_ids")]
		[XmlArrayItem("string")]
		public List<string> CityIds
		{
			get;
			set;
		}

		[XmlElement("merchant_name")]
		public string MerchantName
		{
			get;
			set;
		}

		[XmlElement("purchase_mode")]
		public string PurchaseMode
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

		[XmlElement("voucher_type")]
		public string VoucherType
		{
			get;
			set;
		}
	}
}
