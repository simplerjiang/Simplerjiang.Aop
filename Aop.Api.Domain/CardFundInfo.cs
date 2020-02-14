using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CardFundInfo : AopObject
	{
		[XmlElement("fundaccount")]
		public string Fundaccount
		{
			get;
			set;
		}

		[XmlElement("fundtype")]
		public string Fundtype
		{
			get;
			set;
		}
	}
}
