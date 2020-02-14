using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class UseRuleInfo : AopObject
	{
		[XmlArray("suitable_shops")]
		[XmlArrayItem("string")]
		public List<string> SuitableShops
		{
			get;
			set;
		}

		[XmlArray("use_mode")]
		[XmlArrayItem("string")]
		public List<string> UseMode
		{
			get;
			set;
		}
	}
}
