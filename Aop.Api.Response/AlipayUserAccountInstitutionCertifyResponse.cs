using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserAccountInstitutionCertifyResponse : AopResponse
	{
		[XmlElement("match")]
		public string Match
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
