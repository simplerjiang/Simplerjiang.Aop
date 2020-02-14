using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicThirdCustomerServiceResponse : AopResponse
	{
		[XmlElement("public_name")]
		public string PublicName
		{
			get;
			set;
		}
	}
}
