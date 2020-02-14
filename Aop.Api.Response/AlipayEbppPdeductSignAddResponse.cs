using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppPdeductSignAddResponse : AopResponse
	{
		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}

		[XmlElement("agreement_status")]
		public string AgreementStatus
		{
			get;
			set;
		}

		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("notify_config")]
		public string NotifyConfig
		{
			get;
			set;
		}

		[XmlElement("out_agreement_id")]
		public string OutAgreementId
		{
			get;
			set;
		}

		[XmlArray("pay_config")]
		[XmlArrayItem("string")]
		public List<string> PayConfig
		{
			get;
			set;
		}

		[XmlElement("sign_date")]
		public string SignDate
		{
			get;
			set;
		}
	}
}
