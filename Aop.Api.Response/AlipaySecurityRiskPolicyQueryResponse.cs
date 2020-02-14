using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskPolicyQueryResponse : AopResponse
	{
		[XmlElement("has_to_check")]
		public bool HasToCheck
		{
			get;
			set;
		}

		[XmlElement("level")]
		public long Level
		{
			get;
			set;
		}

		[XmlElement("query_success")]
		public bool QuerySuccess
		{
			get;
			set;
		}

		[XmlElement("security_id")]
		public string SecurityId
		{
			get;
			set;
		}

		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}

		[XmlElement("template_code")]
		public string TemplateCode
		{
			get;
			set;
		}

		[XmlElement("template_desc")]
		public string TemplateDesc
		{
			get;
			set;
		}

		[XmlElement("verify_id")]
		public string VerifyId
		{
			get;
			set;
		}

		[XmlElement("verify_url")]
		public string VerifyUrl
		{
			get;
			set;
		}
	}
}
