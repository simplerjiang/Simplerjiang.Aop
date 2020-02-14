using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoLogisticsExpressOrderQueryResponse : AopResponse
	{
		[XmlElement("accept_type")]
		public string AcceptType
		{
			get;
			set;
		}

		[XmlElement("cancel_cause")]
		public string CancelCause
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

		[XmlElement("create_time")]
		public string CreateTime
		{
			get;
			set;
		}

		[XmlElement("fare_claims_amount")]
		public string FareClaimsAmount
		{
			get;
			set;
		}

		[XmlElement("last_modified_time")]
		public string LastModifiedTime
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

		[XmlElement("pay_status")]
		public string PayStatus
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

		[XmlElement("trade_amount")]
		public string TradeAmount
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
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
