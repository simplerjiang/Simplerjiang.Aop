using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CustomerEntity : AopObject
	{
		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}

		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("id")]
		public string Id
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

		[XmlArray("tags")]
		[XmlArrayItem("customer_tag")]
		public List<CustomerTag> Tags
		{
			get;
			set;
		}
	}
}
