using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class SsdataDataserviceRiskAntifraudlistQueryResponse : AopResponse
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("hit")]
		public string Hit
		{
			get;
			set;
		}

		[XmlElement("risk_code")]
		public string RiskCode
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
