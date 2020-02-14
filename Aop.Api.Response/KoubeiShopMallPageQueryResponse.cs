using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiShopMallPageQueryResponse : AopResponse
	{
		[XmlElement("mall_url")]
		public string MallUrl
		{
			get;
			set;
		}
	}
}
