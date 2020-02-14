using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandAssetdeliveryCompleteSyncModel : AopObject
	{
		[XmlArray("asset_delivery_details")]
		[XmlArrayItem("asset_delivery_detail")]
		public List<AssetDeliveryDetail> AssetDeliveryDetails
		{
			get;
			set;
		}
	}
}
