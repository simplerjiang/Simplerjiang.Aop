using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceIotMdeviceprodAssetapplyQueryModel : AopObject
	{
		[XmlElement("apply_order_id")]
		public string ApplyOrderId
		{
			get;
			set;
		}
	}
}
