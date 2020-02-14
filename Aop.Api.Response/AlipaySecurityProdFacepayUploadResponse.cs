using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdFacepayUploadResponse : AopResponse
	{
		[XmlElement("ftoken")]
		public string Ftoken
		{
			get;
			set;
		}

		[XmlElement("user_auth_id_hint")]
		public string UserAuthIdHint
		{
			get;
			set;
		}

		[XmlElement("user_auth_id_type")]
		public string UserAuthIdType
		{
			get;
			set;
		}
	}
}
