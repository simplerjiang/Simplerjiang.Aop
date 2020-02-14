using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiItemExtitemInfoCreateModel : AopObject
	{
		[XmlArray("brand_level_info_list")]
		[XmlArrayItem("brand_level_info")]
		public List<BrandLevelInfo> BrandLevelInfoList
		{
			get;
			set;
		}

		[XmlElement("brief")]
		public string Brief
		{
			get;
			set;
		}

		[XmlArray("category_level_info_list")]
		[XmlArrayItem("category_level_info")]
		public List<CategoryLevelInfo> CategoryLevelInfoList
		{
			get;
			set;
		}

		[XmlElement("count")]
		public long Count
		{
			get;
			set;
		}

		[XmlElement("country")]
		public string Country
		{
			get;
			set;
		}

		[XmlElement("currency")]
		public string Currency
		{
			get;
			set;
		}

		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}

		[XmlElement("goods_id")]
		public string GoodsId
		{
			get;
			set;
		}

		[XmlElement("goods_name")]
		public string GoodsName
		{
			get;
			set;
		}

		[XmlElement("inner_goods_id")]
		public string InnerGoodsId
		{
			get;
			set;
		}

		[XmlElement("item_format")]
		public string ItemFormat
		{
			get;
			set;
		}

		[XmlElement("need_modify")]
		public bool NeedModify
		{
			get;
			set;
		}

		[XmlElement("pack")]
		public string Pack
		{
			get;
			set;
		}

		[XmlArray("picture_id_list")]
		[XmlArrayItem("string")]
		public List<string> PictureIdList
		{
			get;
			set;
		}

		[XmlElement("price")]
		public long Price
		{
			get;
			set;
		}

		[XmlElement("specification")]
		public string Specification
		{
			get;
			set;
		}

		[XmlElement("unit")]
		public string Unit
		{
			get;
			set;
		}
	}
}
