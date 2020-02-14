using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppIndustryOrderCreateModel : AopObject
	{
		[XmlElement("ability_code")]
		public string AbilityCode
		{
			get;
			set;
		}

		[XmlElement("bill_date")]
		public string BillDate
		{
			get;
			set;
		}

		[XmlElement("bill_key")]
		public string BillKey
		{
			get;
			set;
		}

		[XmlElement("biz_amount")]
		public string BizAmount
		{
			get;
			set;
		}

		[XmlElement("biz_inst_short_name")]
		public string BizInstShortName
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("fine_amount")]
		public string FineAmount
		{
			get;
			set;
		}

		[XmlElement("identity_no")]
		public string IdentityNo
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("owner_name")]
		public string OwnerName
		{
			get;
			set;
		}

		[XmlElement("province_code")]
		public string ProvinceCode
		{
			get;
			set;
		}

		[XmlElement("sub_biz_type")]
		public string SubBizType
		{
			get;
			set;
		}
	}
}
