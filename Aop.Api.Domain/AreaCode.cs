using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AreaCode : AopObject
	{
		[XmlElement("area_type")]
		public string AreaType
		{
			get;
			set;
		}

		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}
	}
}
