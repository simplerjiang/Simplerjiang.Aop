using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishGroupQueryResponse : AopResponse
	{
		[XmlArray("kb_dish_group_list")]
		[XmlArrayItem("kbdish_group_info")]
		public List<KbdishGroupInfo> KbDishGroupList
		{
			get;
			set;
		}
	}
}
