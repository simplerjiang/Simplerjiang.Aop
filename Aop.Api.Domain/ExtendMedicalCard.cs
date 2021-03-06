using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExtendMedicalCard : AopObject
	{
		[XmlElement("card_org_name")]
		public string CardOrgName
		{
			get;
			set;
		}

		[XmlElement("card_org_no")]
		public string CardOrgNo
		{
			get;
			set;
		}

		[XmlElement("city")]
		public string City
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

		[XmlElement("gmt_sign")]
		public string GmtSign
		{
			get;
			set;
		}

		[XmlElement("medical_card_id")]
		public string MedicalCardId
		{
			get;
			set;
		}

		[XmlElement("medical_card_no")]
		public string MedicalCardNo
		{
			get;
			set;
		}

		[XmlElement("medical_card_type")]
		public string MedicalCardType
		{
			get;
			set;
		}

		[XmlElement("out_user_name")]
		public string OutUserName
		{
			get;
			set;
		}

		[XmlElement("sign_status")]
		public string SignStatus
		{
			get;
			set;
		}
	}
}
