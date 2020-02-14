using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceIotMdeviceprodAssetQueryModel : AopObject
	{
		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}
	}
}
