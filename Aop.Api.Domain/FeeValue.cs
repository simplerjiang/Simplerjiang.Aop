using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FeeValue : AopObject
	{
		[XmlElement("bottom_cent")]
		public string BottomCent
		{
			get;
			set;
		}

		[XmlElement("currency_code")]
		public string CurrencyCode
		{
			get;
			set;
		}

		[XmlElement("fix_cent")]
		public string FixCent
		{
			get;
			set;
		}

		[XmlElement("lower")]
		public string Lower
		{
			get;
			set;
		}

		[XmlElement("rate_unit")]
		public string RateUnit
		{
			get;
			set;
		}

		[XmlElement("rate_value")]
		public string RateValue
		{
			get;
			set;
		}

		[XmlElement("top_cent")]
		public string TopCent
		{
			get;
			set;
		}

		[XmlElement("upper")]
		public string Upper
		{
			get;
			set;
		}
	}
}
