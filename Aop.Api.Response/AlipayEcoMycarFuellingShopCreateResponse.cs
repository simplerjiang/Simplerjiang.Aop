using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarFuellingShopCreateResponse : AopResponse
	{
		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}
	}
}
