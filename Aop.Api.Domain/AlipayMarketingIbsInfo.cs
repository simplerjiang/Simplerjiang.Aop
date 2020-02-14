using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingIbsInfo : AopObject
	{
		[XmlElement("accuracy")]
		public string Accuracy
		{
			get;
			set;
		}

		[XmlElement("altitude")]
		public string Altitude
		{
			get;
			set;
		}

		[XmlElement("latitude")]
		public string Latitude
		{
			get;
			set;
		}

		[XmlElement("longitude")]
		public string Longitude
		{
			get;
			set;
		}

		[XmlElement("time")]
		public string Time
		{
			get;
			set;
		}
	}
}
