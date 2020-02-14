using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiAdvertDeliveryDiscountQueryModel : AopObject
	{
		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}
	}
}
