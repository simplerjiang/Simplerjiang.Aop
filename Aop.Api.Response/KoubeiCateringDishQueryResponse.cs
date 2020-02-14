using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishQueryResponse : AopResponse
	{
		[XmlArray("kb_dish_info_list")]
		[XmlArrayItem("kbdish_info")]
		public List<KbdishInfo> KbDishInfoList
		{
			get;
			set;
		}
	}
}
