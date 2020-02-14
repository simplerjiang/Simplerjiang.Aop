using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ItemPackageInfo : AopObject
	{
		[XmlArray("item_units")]
		[XmlArrayItem("item_unit_info")]
		public List<ItemUnitInfo> ItemUnits
		{
			get;
			set;
		}

		[XmlElement("title")]
		public string Title
		{
			get;
			set;
		}
	}
}
