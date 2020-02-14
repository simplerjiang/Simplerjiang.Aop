using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicAccountCreateResponse : AopResponse
	{
		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}
	}
}
