using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdIrisVerifyResponse : AopResponse
	{
		[XmlElement("biz_token")]
		public string BizToken
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("iris_id")]
		public string IrisId
		{
			get;
			set;
		}

		[XmlElement("person_id")]
		public string PersonId
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
