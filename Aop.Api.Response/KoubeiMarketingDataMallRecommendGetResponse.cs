using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMarketingDataMallRecommendGetResponse : AopResponse
	{
		[XmlElement("has_more")]
		public bool HasMore
		{
			get;
			set;
		}

		[XmlArray("items")]
		[XmlArrayItem("item_resp")]
		public List<ItemResp> Items
		{
			get;
			set;
		}
	}
}
