using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EduSourceInfo : AopObject
	{
		[XmlElement("logo")]
		public string Logo
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
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
