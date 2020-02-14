using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandAssetdeliveryAssignQueryResponse : AopResponse
	{
		[XmlArray("asset_delivery_items")]
		[XmlArrayItem("asset_delivery_item")]
		public List<AssetDeliveryItem> AssetDeliveryItems
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
