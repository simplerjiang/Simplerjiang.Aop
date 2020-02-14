using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class EpInfo : AopObject
	{
		[XmlArray("ep_element_list")]
		[XmlArrayItem("ep_element")]
		public List<EpElement> EpElementList
		{
			get;
			set;
		}
	}
}
