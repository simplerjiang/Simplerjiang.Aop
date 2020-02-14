using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingDataMallRecommendGetModel : AopObject
	{
		[XmlElement("count")]
		public long Count
		{
			get;
			set;
		}

		[XmlElement("data_type")]
		public string DataType
		{
			get;
			set;
		}

		[XmlElement("device_id")]
		public string DeviceId
		{
			get;
			set;
		}

		[XmlElement("mall_id")]
		public string MallId
		{
			get;
			set;
		}

		[XmlArray("shop_category_ids")]
		[XmlArrayItem("string")]
		public List<string> ShopCategoryIds
		{
			get;
			set;
		}

		[XmlElement("start")]
		public long Start
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
