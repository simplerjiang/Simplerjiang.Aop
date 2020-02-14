using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserGetResponse : AopResponse
	{
		[XmlElement("alipay_user_detail")]
		public AlipayUserDetail AlipayUserDetail
		{
			get;
			set;
		}
	}
}
