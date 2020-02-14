using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FilterTag : AopObject
	{
		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}

		[XmlElement("filter_items")]
		public string FilterItems
		{
			get;
			set;
		}
	}
}
