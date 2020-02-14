using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishSkuInfo : AopObject
	{
		[XmlElement("box_price")]
		public string BoxPrice
		{
			get;
			set;
		}

		[XmlElement("dish_id")]
		public string DishId
		{
			get;
			set;
		}

		[XmlArray("dish_packages_detail_list")]
		[XmlArrayItem("kbdish_packages_detail_info")]
		public List<KbdishPackagesDetailInfo> DishPackagesDetailList
		{
			get;
			set;
		}

		[XmlElement("goods_sku_id")]
		public string GoodsSkuId
		{
			get;
			set;
		}

		[XmlElement("member_price")]
		public string MemberPrice
		{
			get;
			set;
		}

		[XmlElement("out_sku_id")]
		public string OutSkuId
		{
			get;
			set;
		}

		[XmlElement("sell_price")]
		public string SellPrice
		{
			get;
			set;
		}

		[XmlElement("sku_ext_content")]
		public string SkuExtContent
		{
			get;
			set;
		}

		[XmlElement("sku_id")]
		public string SkuId
		{
			get;
			set;
		}

		[XmlElement("sku_sort")]
		public string SkuSort
		{
			get;
			set;
		}

		[XmlElement("spec_code_01")]
		public string SpecCode01
		{
			get;
			set;
		}

		[XmlElement("spec_code_02")]
		public string SpecCode02
		{
			get;
			set;
		}

		[XmlElement("spec_code_03")]
		public string SpecCode03
		{
			get;
			set;
		}

		[XmlElement("spec_code_04")]
		public string SpecCode04
		{
			get;
			set;
		}

		[XmlElement("spec_code_05")]
		public string SpecCode05
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
	}
}
