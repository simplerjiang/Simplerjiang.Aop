using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneCouponReceiveResponse : AopResponse
	{
		[XmlElement("policy_no")]
		public string PolicyNo
		{
			get;
			set;
		}

		[XmlElement("product")]
		public InsProduct Product
		{
			get;
			set;
		}
	}
}
