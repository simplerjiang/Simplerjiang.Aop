using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarMaintainBizorderQueryResponse : AopResponse
	{
		[XmlElement("appoint_affirm_time")]
		public string AppointAffirmTime
		{
			get;
			set;
		}

		[XmlElement("appoint_end_time")]
		public string AppointEndTime
		{
			get;
			set;
		}

		[XmlElement("appoint_start_time")]
		public string AppointStartTime
		{
			get;
			set;
		}

		[XmlElement("appoint_status")]
		public long AppointStatus
		{
			get;
			set;
		}

		[XmlElement("arrive_time")]
		public string ArriveTime
		{
			get;
			set;
		}

		[XmlElement("biz_status_txt")]
		public string BizStatusTxt
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public long BizType
		{
			get;
			set;
		}

		[XmlElement("car_id")]
		public string CarId
		{
			get;
			set;
		}

		[XmlElement("create_time")]
		public string CreateTime
		{
			get;
			set;
		}

		[XmlArray("order_express_list")]
		[XmlArrayItem("maintain_biz_order_express")]
		public List<MaintainBizOrderExpress> OrderExpressList
		{
			get;
			set;
		}

		[XmlArray("order_goods_list")]
		[XmlArrayItem("maintain_biz_order_goods")]
		public List<MaintainBizOrderGoods> OrderGoodsList
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlArray("order_server_list")]
		[XmlArrayItem("maintain_biz_order_server")]
		public List<MaintainBizOrderServer> OrderServerList
		{
			get;
			set;
		}

		[XmlElement("order_status")]
		public long OrderStatus
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

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("out_shop_id")]
		public string OutShopId
		{
			get;
			set;
		}

		[XmlElement("pay_time")]
		public string PayTime
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

		[XmlElement("shop_id")]
		public long ShopId
		{
			get;
			set;
		}

		[XmlElement("shop_name")]
		public string ShopName
		{
			get;
			set;
		}

		[XmlElement("update_time")]
		public string UpdateTime
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
