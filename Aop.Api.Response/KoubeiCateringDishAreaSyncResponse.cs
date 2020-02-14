using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishAreaSyncResponse : AopResponse
	{
		[XmlElement("kb_dish_area")]
		public KbdishAreaInfo KbDishArea
		{
			get;
			set;
		}
	}
}
