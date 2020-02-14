using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishGroupSyncResponse : AopResponse
	{
		[XmlElement("kb_dish_group")]
		public KbdishGroupInfo KbDishGroup
		{
			get;
			set;
		}
	}
}
