using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KbdishGroupDetailInfo : AopObject
	{
		[XmlElement("add_price")]
		public string AddPrice
		{
			get;
			set;
		}

		[XmlElement("detail_count")]
		public string DetailCount
		{
			get;
			set;
		}

		[XmlElement("detail_dish_id")]
		public string DetailDishId
		{
			get;
			set;
		}

		[XmlElement("detail_is_default")]
		public string DetailIsDefault
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

		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}
	}
}
