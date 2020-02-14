using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiRetailItemQueryResponse : AopResponse
	{
		[XmlElement("cover")]
		public string Cover
		{
			get;
			set;
		}

		[XmlArray("descriptions")]
		[XmlArrayItem("retail_item_description")]
		public List<RetailItemDescription> Descriptions
		{
			get;
			set;
		}

		[XmlElement("discount_rate")]
		public string DiscountRate
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("gmt_start")]
		public string GmtStart
		{
			get;
			set;
		}

		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("item_status")]
		public string ItemStatus
		{
			get;
			set;
		}

		[XmlElement("original_amount")]
		public string OriginalAmount
		{
			get;
			set;
		}

		[XmlArray("picture_list")]
		[XmlArrayItem("string")]
		public List<string> PictureList
		{
			get;
			set;
		}

		[XmlElement("reduce_to_amount")]
		public string ReduceToAmount
		{
			get;
			set;
		}

		[XmlArray("shop_list")]
		[XmlArrayItem("string")]
		public List<string> ShopList
		{
			get;
			set;
		}

		[XmlArray("sku_list")]
		[XmlArrayItem("string")]
		public List<string> SkuList
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}

		[XmlElement("value_amount")]
		public string ValueAmount
		{
			get;
			set;
		}
	}
}
