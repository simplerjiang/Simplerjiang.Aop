using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BrandLevelInfo : AopObject
	{
		[XmlElement("brand_code")]
		public string BrandCode
		{
			get;
			set;
		}

		[XmlElement("brand_level")]
		public long BrandLevel
		{
			get;
			set;
		}

		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}
	}
}
