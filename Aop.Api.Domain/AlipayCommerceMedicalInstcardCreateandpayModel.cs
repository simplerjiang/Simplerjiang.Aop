using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceMedicalInstcardCreateandpayModel : AopObject
	{
		[XmlElement("bill_no")]
		public string BillNo
		{
			get;
			set;
		}

		[XmlElement("body")]
		public string Body
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

		[XmlElement("extend_params")]
		public string ExtendParams
		{
			get;
			set;
		}

		[XmlElement("gmt_out_create")]
		public string GmtOutCreate
		{
			get;
			set;
		}

		[XmlElement("industry")]
		public string Industry
		{
			get;
			set;
		}

		[XmlElement("is_insurance")]
		public string IsInsurance
		{
			get;
			set;
		}

		[XmlElement("medical_card_inst_id")]
		public string MedicalCardInstId
		{
			get;
			set;
		}

		[XmlElement("org_name")]
		public string OrgName
		{
			get;
			set;
		}

		[XmlElement("org_no")]
		public string OrgNo
		{
			get;
			set;
		}

		[XmlElement("out_trade_no")]
		public string OutTradeNo
		{
			get;
			set;
		}

		[XmlElement("patient_card_no")]
		public string PatientCardNo
		{
			get;
			set;
		}

		[XmlElement("patient_card_type")]
		public string PatientCardType
		{
			get;
			set;
		}

		[XmlElement("patient_mobile")]
		public string PatientMobile
		{
			get;
			set;
		}

		[XmlElement("patient_name")]
		public string PatientName
		{
			get;
			set;
		}

		[XmlElement("request_content")]
		public string RequestContent
		{
			get;
			set;
		}

		[XmlElement("scene")]
		public string Scene
		{
			get;
			set;
		}

		[XmlElement("seller_id")]
		public string SellerId
		{
			get;
			set;
		}

		[XmlElement("serial_no")]
		public string SerialNo
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

		[XmlElement("timeout_express")]
		public string TimeoutExpress
		{
			get;
			set;
		}

		[XmlElement("total_amount")]
		public string TotalAmount
		{
			get;
			set;
		}
	}
}
