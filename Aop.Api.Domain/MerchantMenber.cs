using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MerchantMenber : AopObject
	{
		[XmlElement("birth")]
		public string Birth
		{
			get;
			set;
		}

		[XmlElement("cell")]
		public string Cell
		{
			get;
			set;
		}

		[XmlElement("gende")]
		public string Gende
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
