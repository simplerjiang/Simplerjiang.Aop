using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OverseasTravelRate : AopObject
	{
		[XmlElement("currency")]
		public string Currency
		{
			get;
			set;
		}

		[XmlElement("currency_icon")]
		public string CurrencyIcon
		{
			get;
			set;
		}

		[XmlElement("rate")]
		public string Rate
		{
			get;
			set;
		}
	}
}
