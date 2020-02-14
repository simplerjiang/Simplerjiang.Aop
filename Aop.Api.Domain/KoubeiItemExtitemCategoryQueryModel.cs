using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiItemExtitemCategoryQueryModel : AopObject
	{
		[XmlElement("parent_id")]
		public string ParentId
		{
			get;
			set;
		}
	}
}
