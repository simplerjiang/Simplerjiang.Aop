using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringCookConditionBatchqueryResponse : AopResponse
	{
		[XmlElement("kb_dish_cook_page_info")]
		public PaginationCook KbDishCookPageInfo
		{
			get;
			set;
		}
	}
}
