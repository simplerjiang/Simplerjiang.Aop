using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ContactInfo : AopObject
	{
		[XmlElement("email")]
		public string Email
		{
			get;
			set;
		}

		[XmlElement("id_card_no")]
		public string IdCardNo
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
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

		[XmlElement("phone")]
		public string Phone
		{
			get;
			set;
		}

		[XmlArray("tag")]
		[XmlArrayItem("string")]
		public List<string> Tag
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
