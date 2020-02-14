using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AreaInfo : AopObject
	{
		[XmlElement("city")]
		public string City
		{
			get;
			set;
		}

		[XmlElement("province")]
		public string Province
		{
			get;
			set;
		}
	}
}
