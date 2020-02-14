using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsProdTag : AopObject
	{
		[XmlElement("tag_code")]
		public string TagCode
		{
			get;
			set;
		}

		[XmlElement("tag_value")]
		public string TagValue
		{
			get;
			set;
		}
	}
}
