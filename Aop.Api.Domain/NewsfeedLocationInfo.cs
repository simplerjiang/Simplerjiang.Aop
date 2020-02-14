using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class NewsfeedLocationInfo : AopObject
	{
		[XmlElement("ad_code")]
		public string AdCode
		{
			get;
			set;
		}

		[XmlElement("lat")]
		public string Lat
		{
			get;
			set;
		}

		[XmlElement("lon")]
		public string Lon
		{
			get;
			set;
		}
	}
}
