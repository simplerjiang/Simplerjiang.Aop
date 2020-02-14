using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandAssetproduceCompleteSyncResponse : AopResponse
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
