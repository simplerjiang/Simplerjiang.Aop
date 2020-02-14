using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CardTypeVO : AopObject
	{
		[XmlElement("card_type")]
		public string CardType
		{
			get;
			set;
		}

		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}
	}
}
