using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class VoucherDetailInfo : AopObject
	{
		[XmlElement("asset_id")]
		public string AssetId
		{
			get;
			set;
		}

		[XmlElement("effect_time")]
		public string EffectTime
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("forbbiden_time")]
		public ForbbidenTime ForbbidenTime
		{
			get;
			set;
		}

		[XmlElement("invalid_time")]
		public string InvalidTime
		{
			get;
			set;
		}

		[XmlElement("sku_codes")]
		public string SkuCodes
		{
			get;
			set;
		}

		[XmlArray("time_rules")]
		[XmlArrayItem("use_time")]
		public List<UseTime> TimeRules
		{
			get;
			set;
		}

		[XmlElement("use_condition")]
		public string UseCondition
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

		[XmlElement("voucher_type")]
		public string VoucherType
		{
			get;
			set;
		}
	}
}
