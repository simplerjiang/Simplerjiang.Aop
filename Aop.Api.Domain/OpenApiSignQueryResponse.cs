using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OpenApiSignQueryResponse : AopObject
	{
		[XmlElement("agreement_no")]
		public string AgreementNo
		{
			get;
			set;
		}

		[XmlElement("invalid_time")]
		public string InvalidTime
		{
			get;
			set;
		}

		[XmlElement("personal_product_code")]
		public string PersonalProductCode
		{
			get;
			set;
		}

		[XmlElement("pricipal_type")]
		public string PricipalType
		{
			get;
			set;
		}

		[XmlElement("principal_id")]
		public string PrincipalId
		{
			get;
			set;
		}

		[XmlElement("sign_scene")]
		public string SignScene
		{
			get;
			set;
		}

		[XmlElement("sign_time")]
		public string SignTime
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("third_party_type")]
		public string ThirdPartyType
		{
			get;
			set;
		}

		[XmlElement("valid_time")]
		public string ValidTime
		{
			get;
			set;
		}
	}
}
