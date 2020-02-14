using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCateringDishConditionBatchqueryResponse : AopResponse
	{
		[XmlElement("kb_dish_page_info")]
		public PaginationDish KbDishPageInfo
		{
			get;
			set;
		}
	}
}
