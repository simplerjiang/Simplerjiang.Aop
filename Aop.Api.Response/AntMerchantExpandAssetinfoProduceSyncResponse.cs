using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandAssetinfoProduceSyncResponse : AopResponse
	{
		[XmlArray("info_results")]
		[XmlArrayItem("asset_result")]
		public List<AssetResult> InfoResults
		{
			get;
			set;
		}
	}
}
