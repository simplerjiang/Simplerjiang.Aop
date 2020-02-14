using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignAssetDetailQueryModel : AopObject
	{
		[XmlElement("asset_id")]
		public string AssetId
		{
			get;
			set;
		}

		[XmlElement("asset_type")]
		public string AssetType
		{
			get;
			set;
		}
	}
}
