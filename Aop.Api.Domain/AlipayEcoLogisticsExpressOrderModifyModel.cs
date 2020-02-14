using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoLogisticsExpressOrderModifyModel : AopObject
	{
		[XmlElement("accept_type")]
		public string AcceptType
		{
			get;
			set;
		}

		[XmlElement("courier_alipay_account")]
		public string CourierAlipayAccount
		{
			get;
			set;
		}

		[XmlElement("courier_emp_num")]
		public string CourierEmpNum
		{
			get;
			set;
		}

		[XmlElement("courier_head_img")]
		public string CourierHeadImg
		{
			get;
			set;
		}

		[XmlElement("courier_id_card")]
		public string CourierIdCard
		{
			get;
			set;
		}

		[XmlElement("courier_mobile")]
		public string CourierMobile
		{
			get;
			set;
		}

		[XmlElement("courier_name")]
		public string CourierName
		{
			get;
			set;
		}

		[XmlElement("goods_weight")]
		public long GoodsWeight
		{
			get;
			set;
		}

		[XmlElement("logis_merch_code")]
		public string LogisMerchCode
		{
			get;
			set;
		}

		[XmlElement("order_amount")]
		public string OrderAmount
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

		[XmlElement("order_status")]
		public string OrderStatus
		{
			get;
			set;
		}

		[XmlElement("product_type_change_reason")]
		public string ProductTypeChangeReason
		{
			get;
			set;
		}

		[XmlElement("product_type_code")]
		public string ProductTypeCode
		{
			get;
			set;
		}

		[XmlElement("refuse_code")]
		public string RefuseCode
		{
			get;
			set;
		}

		[XmlElement("refuse_desc")]
		public string RefuseDesc
		{
			get;
			set;
		}

		[XmlElement("site_area_code")]
		public string SiteAreaCode
		{
			get;
			set;
		}

		[XmlElement("site_code")]
		public string SiteCode
		{
			get;
			set;
		}

		[XmlElement("site_complain_tel")]
		public string SiteComplainTel
		{
			get;
			set;
		}

		[XmlElement("site_detail_addr")]
		public string SiteDetailAddr
		{
			get;
			set;
		}

		[XmlElement("site_leader_mobile")]
		public string SiteLeaderMobile
		{
			get;
			set;
		}

		[XmlElement("site_leader_name")]
		public string SiteLeaderName
		{
			get;
			set;
		}

		[XmlElement("site_name")]
		public string SiteName
		{
			get;
			set;
		}

		[XmlElement("way_bill_no")]
		public string WayBillNo
		{
			get;
			set;
		}
	}
}
