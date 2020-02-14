using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishCookQueryResponse : AopResponse
	{
		[XmlArray("kb_cook_list")]
		[XmlArrayItem("kbdish_cook_info")]
		public List<KbdishCookInfo> KbCookList
		{
			get;
			set;
		}
	}
}
