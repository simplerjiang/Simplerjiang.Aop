using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarMaintainServiceproductUpdateResponse : AopResponse
	{
		[XmlElement("product_id")]
		public long ProductId
		{
			get;
			set;
		}
	}
}
