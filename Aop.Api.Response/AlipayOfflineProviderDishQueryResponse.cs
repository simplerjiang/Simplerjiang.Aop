using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineProviderDishQueryResponse : AopResponse
	{
		[XmlElement("items")]
		public long Items
		{
			get;
			set;
		}

		[XmlArray("list")]
		[XmlArrayItem("isv_shop_dish_model")]
		public List<IsvShopDishModel> List
		{
			get;
			set;
		}

		[XmlElement("page")]
		public long Page
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("pages")]
		public long Pages
		{
			get;
			set;
		}
	}
}
