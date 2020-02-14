using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandAssetproduceAssignQueryResponse : AopResponse
	{
		[XmlArray("asset_produce_items")]
		[XmlArrayItem("asset_produce_item")]
		public List<AssetProduceItem> AssetProduceItems
		{
			get;
			set;
		}

		[XmlElement("has_next_page")]
		public bool HasNextPage
		{
			get;
			set;
		}
	}
}
