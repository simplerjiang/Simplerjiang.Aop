using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceRiskBusinesslicenseCertifyResponse : AopResponse
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("bis_token")]
		public string BisToken
		{
			get;
			set;
		}

		[XmlElement("check_result")]
		public bool CheckResult
		{
			get;
			set;
		}

		[XmlElement("credit_code")]
		public string CreditCode
		{
			get;
			set;
		}

		[XmlElement("ent_legal_name")]
		public string EntLegalName
		{
			get;
			set;
		}

		[XmlElement("ent_name")]
		public string EntName
		{
			get;
			set;
		}

		[XmlElement("expires")]
		public string Expires
		{
			get;
			set;
		}

		[XmlElement("expires_end")]
		public string ExpiresEnd
		{
			get;
			set;
		}

		[XmlElement("expires_start")]
		public string ExpiresStart
		{
			get;
			set;
		}

		[XmlElement("match_param")]
		public string MatchParam
		{
			get;
			set;
		}

		[XmlElement("no_match_param")]
		public string NoMatchParam
		{
			get;
			set;
		}

		[XmlElement("unique_id")]
		public string UniqueId
		{
			get;
			set;
		}
	}
}
