using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAssetPointOrderCreateResponse : AopResponse
	{
		[XmlElement("alipay_order_no")]
		public string AlipayOrderNo
		{
			get;
			set;
		}
	}
}
