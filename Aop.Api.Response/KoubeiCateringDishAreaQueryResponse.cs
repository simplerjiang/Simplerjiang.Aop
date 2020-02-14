using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishAreaQueryResponse : AopResponse
	{
		[XmlArray("kb_dish_area_list")]
		[XmlArrayItem("kbdish_area_info")]
		public List<KbdishAreaInfo> KbDishAreaList
		{
			get;
			set;
		}
	}
}
