using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ClaimProgress : AopObject
	{
		[XmlElement("update_content")]
		public string UpdateContent
		{
			get;
			set;
		}

		[XmlElement("update_time")]
		public string UpdateTime
		{
			get;
			set;
		}
	}
}
