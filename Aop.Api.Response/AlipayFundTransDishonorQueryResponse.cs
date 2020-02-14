using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransDishonorQueryResponse : AopResponse
	{
		[XmlArray("dishonor_order_list")]
		[XmlArrayItem("dishonor_order")]
		public List<DishonorOrder> DishonorOrderList
		{
			get;
			set;
		}

		[XmlElement("items")]
		public string Items
		{
			get;
			set;
		}

		[XmlElement("items_per_page")]
		public string ItemsPerPage
		{
			get;
			set;
		}

		[XmlElement("page")]
		public string Page
		{
			get;
			set;
		}
	}
}
