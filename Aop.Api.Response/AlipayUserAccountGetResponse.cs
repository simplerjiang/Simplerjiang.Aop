using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAccountGetResponse : AopResponse
	{
		[XmlElement("alipay_account")]
		public AlipayAccount AlipayAccount
		{
			get;
			set;
		}
	}
}
