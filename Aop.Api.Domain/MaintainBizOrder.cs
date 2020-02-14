using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MaintainBizOrder : AopObject
	{
		[XmlElement("origin_cost")]
		public string OriginCost
		{
			get;
			set;
		}

		[XmlElement("out_product_id")]
		public string OutProductId
		{
			get;
			set;
		}

		[XmlElement("real_cost")]
		public string RealCost
		{
			get;
			set;
		}

		[XmlElement("sale_num")]
		public long SaleNum
		{
			get;
			set;
		}

		[XmlElement("service_category_id")]
		public long ServiceCategoryId
		{
			get;
			set;
		}
	}
}
