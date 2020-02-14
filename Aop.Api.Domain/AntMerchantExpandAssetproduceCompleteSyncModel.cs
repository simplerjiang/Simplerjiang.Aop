using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandAssetproduceCompleteSyncModel : AopObject
	{
		[XmlArray("asset_produce_details")]
		[XmlArrayItem("item_delivery_detail")]
		public List<ItemDeliveryDetail> AssetProduceDetails
		{
			get;
			set;
		}
	}
}
