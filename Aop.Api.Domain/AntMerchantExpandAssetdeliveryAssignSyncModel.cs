using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandAssetdeliveryAssignSyncModel : AopObject
	{
		[XmlArray("delivery_results")]
		[XmlArrayItem("asset_result")]
		public List<AssetResult> DeliveryResults
		{
			get;
			set;
		}
	}
}
