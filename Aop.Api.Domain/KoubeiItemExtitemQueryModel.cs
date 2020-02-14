using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiItemExtitemQueryModel : AopObject
	{
		[XmlElement("item_code")]
		public string ItemCode
		{
			get;
			set;
		}
	}
}
