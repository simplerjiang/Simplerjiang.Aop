using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SkuPropertyInfo : AopObject
	{
		[XmlElement("key")]
		public string Key
		{
			get;
			set;
		}

		[XmlArray("value")]
		[XmlArrayItem("sku_property_value")]
		public List<SkuPropertyValue> Value
		{
			get;
			set;
		}
	}
}
