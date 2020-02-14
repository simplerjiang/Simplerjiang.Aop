using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class WelfareEcoStoreInfo : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("brand")]
		public string Brand
		{
			get;
			set;
		}

		[XmlElement("code")]
		public string Code
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}
