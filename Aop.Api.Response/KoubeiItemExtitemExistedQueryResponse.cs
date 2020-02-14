using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiItemExtitemExistedQueryResponse : AopResponse
	{
		[XmlArray("existed_list")]
		[XmlArrayItem("string")]
		public List<string> ExistedList
		{
			get;
			set;
		}
	}
}
