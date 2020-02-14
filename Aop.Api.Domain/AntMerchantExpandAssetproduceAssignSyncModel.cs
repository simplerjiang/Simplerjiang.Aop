using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandAssetproduceAssignSyncModel : AopObject
	{
		[XmlArray("asset_results")]
		[XmlArrayItem("asset_result")]
		public List<AssetResult> AssetResults
		{
			get;
			set;
		}
	}
}
