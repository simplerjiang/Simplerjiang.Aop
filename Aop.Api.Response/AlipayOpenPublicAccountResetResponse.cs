using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicAccountResetResponse : AopResponse
	{
		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}
	}
}
