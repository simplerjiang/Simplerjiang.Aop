using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishPackagesDetailInfo : AopObject
	{
		[XmlElement("detail_count")]
		public string DetailCount
		{
			get;
			set;
		}

		[XmlElement("detail_is_select")]
		public string DetailIsSelect
		{
			get;
			set;
		}

		[XmlElement("detail_member_price")]
		public string DetailMemberPrice
		{
			get;
			set;
		}

		[XmlElement("detail_sell_price")]
		public string DetailSellPrice
		{
			get;
			set;
		}

		[XmlElement("detail_sku_id")]
		public string DetailSkuId
		{
			get;
			set;
		}

		[XmlElement("detail_sort")]
		public string DetailSort
		{
			get;
			set;
		}

		[XmlElement("detail_type")]
		public string DetailType
		{
			get;
			set;
		}

		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}

		[XmlElement("packages_sku_id")]
		public string PackagesSkuId
		{
			get;
			set;
		}
	}
}
