using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ShopCategoryConfigInfo : AopObject
	{
		[XmlElement("id")]
		public string Id
		{
			get;
			set;
		}

		[XmlElement("is_leaf")]
		public string IsLeaf
		{
			get;
			set;
		}

		[XmlElement("level")]
		public string Level
		{
			get;
			set;
		}

		[XmlElement("link")]
		public string Link
		{
			get;
			set;
		}

		[XmlElement("nm")]
		public string Nm
		{
			get;
			set;
		}
	}
}
