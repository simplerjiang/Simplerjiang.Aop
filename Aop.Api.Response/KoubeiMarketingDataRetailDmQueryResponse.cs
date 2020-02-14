using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataRetailDmQueryResponse : AopResponse
	{
		[XmlElement("content_id")]
		public string ContentId
		{
			get;
			set;
		}

		[XmlArray("dm_marketing_datas")]
		[XmlArrayItem("dm_activity_shop_data")]
		public List<DmActivityShopData> DmMarketingDatas
		{
			get;
			set;
		}

		[XmlElement("item_code")]
		public string ItemCode
		{
			get;
			set;
		}

		[XmlElement("item_name")]
		public string ItemName
		{
			get;
			set;
		}
	}
}
