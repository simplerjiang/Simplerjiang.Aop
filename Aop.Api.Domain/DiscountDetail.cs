using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DiscountDetail : AopObject
	{
		[XmlElement("discount_amount")]
		public string DiscountAmount
		{
			get;
			set;
		}

		[XmlArray("discount_desc")]
		[XmlArrayItem("string")]
		public List<string> DiscountDesc
		{
			get;
			set;
		}

		[XmlElement("discount_type")]
		public string DiscountType
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

		[XmlElement("is_hit")]
		public string IsHit
		{
			get;
			set;
		}

		[XmlElement("is_purchased")]
		public string IsPurchased
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
	}
}
