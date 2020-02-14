using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCateringTablelistQueryModel : AopObject
	{
		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}
	}
}
