using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieSpaceDomains : AopObject
	{
		[XmlElement("domain")]
		public string Domain
		{
			get;
			set;
		}

		[XmlElement("is_default")]
		public string IsDefault
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
