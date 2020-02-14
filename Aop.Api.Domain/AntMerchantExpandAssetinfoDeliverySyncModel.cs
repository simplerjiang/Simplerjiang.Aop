using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AntMerchantExpandAssetinfoDeliverySyncModel : AopObject
	{
		[XmlArray("asset_infos")]
		[XmlArrayItem("asset_info_item")]
		public List<AssetInfoItem> AssetInfos
		{
			get;
			set;
		}
	}
}
