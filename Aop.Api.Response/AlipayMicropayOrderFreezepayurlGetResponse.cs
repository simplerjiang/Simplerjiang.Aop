using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMicropayOrderFreezepayurlGetResponse : AopResponse
	{
		[XmlElement("pay_freeze_url")]
		public string PayFreezeUrl
		{
			get;
			set;
		}
	}
}
