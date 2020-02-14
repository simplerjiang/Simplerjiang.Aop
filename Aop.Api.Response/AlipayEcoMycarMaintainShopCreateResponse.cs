using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarMaintainShopCreateResponse : AopResponse
	{
		[XmlElement("shop_id")]
		public long ShopId
		{
			get;
			set;
		}
	}
}
