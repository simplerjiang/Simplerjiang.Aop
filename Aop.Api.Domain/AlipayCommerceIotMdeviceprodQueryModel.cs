using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceIotMdeviceprodQueryModel : AopObject
	{
		[XmlElement("asset_id")]
		public string AssetId
		{
			get;
			set;
		}
	}
}
