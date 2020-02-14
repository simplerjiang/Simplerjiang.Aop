using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DiscountModel : AopObject
	{
		[XmlElement("term_discount")]
		public string TermDiscount
		{
			get;
			set;
		}

		[XmlElement("term_no")]
		public long TermNo
		{
			get;
			set;
		}
	}
}
