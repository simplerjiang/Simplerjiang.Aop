using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class NewsfeedLabelInfo : AopObject
	{
		[XmlElement("action")]
		public string Action
		{
			get;
			set;
		}

		[XmlElement("scheme")]
		public string Scheme
		{
			get;
			set;
		}

		[XmlElement("target")]
		public string Target
		{
			get;
			set;
		}
	}
}
