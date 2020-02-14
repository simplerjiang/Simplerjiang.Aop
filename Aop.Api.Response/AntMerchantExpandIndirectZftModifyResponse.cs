using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandIndirectZftModifyResponse : AopResponse
	{
		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}
	}
}
