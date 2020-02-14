using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class IndividualInfo : AopObject
	{
		[XmlElement("date_of_birth")]
		public string DateOfBirth
		{
			get;
			set;
		}

		[XmlElement("id_number")]
		public string IdNumber
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("nationality")]
		public string Nationality
		{
			get;
			set;
		}

		[XmlElement("residential_address")]
		public string ResidentialAddress
		{
			get;
			set;
		}

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
