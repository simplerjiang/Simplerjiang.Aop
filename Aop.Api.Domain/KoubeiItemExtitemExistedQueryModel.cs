using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiItemExtitemExistedQueryModel : AopObject
	{
		[XmlArray("code_list")]
		[XmlArrayItem("string")]
		public List<string> CodeList
		{
			get;
			set;
		}
	}
}
