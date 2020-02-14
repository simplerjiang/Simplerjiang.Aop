using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishCookSyncResponse : AopResponse
	{
		[XmlElement("kb_dish_cook")]
		public KbdishCookInfo KbDishCook
		{
			get;
			set;
		}
	}
}
