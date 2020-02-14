using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMsaasMediarecogVoiceMediaaudioUploadResponse : AopResponse
	{
		[XmlElement("extinfo_a")]
		public string ExtinfoA
		{
			get;
			set;
		}

		[XmlElement("extinfo_b")]
		public string ExtinfoB
		{
			get;
			set;
		}

		[XmlElement("result_memo")]
		public string ResultMemo
		{
			get;
			set;
		}

		[XmlElement("result_status")]
		public string ResultStatus
		{
			get;
			set;
		}
	}
}
