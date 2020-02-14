using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaMerchantCreditlifeRiskApplyResponse : AopResponse
	{
		[XmlElement("open_id")]
		public string OpenId
		{
			get;
			set;
		}

		[XmlElement("zm_grade")]
		public string ZmGrade
		{
			get;
			set;
		}

		[XmlElement("zm_risk")]
		public string ZmRisk
		{
			get;
			set;
		}

		[XmlElement("zm_score")]
		public string ZmScore
		{
			get;
			set;
		}
	}
}
