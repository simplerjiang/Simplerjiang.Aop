using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayTradePayConsultModel : AopObject
	{
		[XmlElement("agreement_no")]
		public string AgreementNo
		{
			get;
			set;
		}

		[XmlElement("apply_amount")]
		public string ApplyAmount
		{
			get;
			set;
		}

		[XmlElement("biz_scene")]
		public string BizScene
		{
			get;
			set;
		}

		[XmlElement("buyer_id")]
		public string BuyerId
		{
			get;
			set;
		}

		[XmlElement("consult_phase")]
		public string ConsultPhase
		{
			get;
			set;
		}

		[XmlElement("extend_params")]
		public string ExtendParams
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}

		[XmlElement("request_no")]
		public string RequestNo
		{
			get;
			set;
		}

		[XmlElement("subject")]
		public string Subject
		{
			get;
			set;
		}
	}
}
