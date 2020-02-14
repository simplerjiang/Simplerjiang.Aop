using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandAssetdeliveryCompleteSyncResponse : AopResponse
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
