using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityProdAmlriskQueryModel : AopObject
	{
		[XmlElement("business_address")]
		public string BusinessAddress
		{
			get;
			set;
		}

		[XmlElement("event_id")]
		public string EventId
		{
			get;
			set;
		}

		[XmlArray("individual_list")]
		[XmlArrayItem("individual_info")]
		public List<IndividualInfo> IndividualList
		{
			get;
			set;
		}

		[XmlElement("legal_name")]
		public string LegalName
		{
			get;
			set;
		}

		[XmlElement("merchant_id")]
		public string MerchantId
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("registered_address")]
		public string RegisteredAddress
		{
			get;
			set;
		}

		[XmlElement("registration_number")]
		public string RegistrationNumber
		{
			get;
			set;
		}
	}
}
