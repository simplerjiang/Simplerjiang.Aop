using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserContractGetResponse : AopResponse
	{
		[XmlElement("alipay_contract")]
		public AlipayContract AlipayContract
		{
			get;
			set;
		}
	}
}
