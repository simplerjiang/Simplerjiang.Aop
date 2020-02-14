using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MaintainBizOrderGoods : AopObject
	{
		[XmlElement("goods_image")]
		public string GoodsImage
		{
			get;
			set;
		}

		[XmlElement("order_goods_id")]
		public string OrderGoodsId
		{
			get;
			set;
		}

		[XmlElement("original_cost")]
		public string OriginalCost
		{
			get;
			set;
		}

		[XmlElement("out_goods_no")]
		public string OutGoodsNo
		{
			get;
			set;
		}

		[XmlElement("out_package_id")]
		public string OutPackageId
		{
			get;
			set;
		}

		[XmlElement("package_name")]
		public string PackageName
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
	}
}
