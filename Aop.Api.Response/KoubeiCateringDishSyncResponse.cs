using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishSyncResponse : AopResponse
	{
		[XmlElement("kb_dish_info")]
		public KbdishInfo KbDishInfo
		{
			get;
			set;
		}
	}
}
