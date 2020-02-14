using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class DiscountRandomModel : AopObject
	{
		[XmlElement("max_amount")]
		public string MaxAmount
		{
			get;
			set;
		}

		[XmlElement("min_amount")]
		public string MinAmount
		{
			get;
			set;
		}

		[XmlElement("probability")]
		public string Probability
		{
			get;
			set;
		}
	}
}
