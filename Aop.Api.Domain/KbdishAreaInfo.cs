using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishAreaInfo : AopObject
	{
		[XmlArray("area_free_list")]
		[XmlArrayItem("kbdish_area_free_info")]
		public List<KbdishAreaFreeInfo> AreaFreeList
		{
			get;
			set;
		}

		[XmlElement("area_id")]
		public string AreaId
		{
			get;
			set;
		}

		[XmlElement("area_name")]
		public string AreaName
		{
			get;
			set;
		}

		[XmlElement("area_sort")]
		public string AreaSort
		{
			get;
			set;
		}

		[XmlElement("create_user")]
		public string CreateUser
		{
			get;
			set;
		}

		[XmlElement("fee_price")]
		public string FeePrice
		{
			get;
			set;
		}

		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
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

		[XmlElement("tab_count")]
		public string TabCount
		{
			get;
			set;
		}

		[XmlArray("tab_list")]
		[XmlArrayItem("kbdish_tab_info")]
		public List<KbdishTabInfo> TabList
		{
			get;
			set;
		}

		[XmlElement("update_user")]
		public string UpdateUser
		{
			get;
			set;
		}
	}
}
