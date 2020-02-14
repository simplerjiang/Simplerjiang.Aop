using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppPdeductSignQueryResponse : AopResponse
	{
		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}

		[XmlElement("bill_key")]
		public string BillKey
		{
			get;
			set;
		}

		[XmlElement("charge_inst")]
		public string ChargeInst
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

		[XmlElement("sign_date")]
		public string SignDate
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
