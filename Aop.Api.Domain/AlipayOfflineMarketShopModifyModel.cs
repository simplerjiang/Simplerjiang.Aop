using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketShopModifyModel : AopObject
	{
		[XmlElement("address")]
		public string Address
		{
			get;
			set;
		}

		[XmlElement("audit_images")]
		public string AuditImages
		{
			get;
			set;
		}

		[XmlElement("auth_letter")]
		public string AuthLetter
		{
			get;
			set;
		}

		[XmlElement("avg_price")]
		public string AvgPrice
		{
			get;
			set;
		}

		[XmlElement("biz_version")]
		public string BizVersion
		{
			get;
			set;
		}

		[XmlElement("box")]
		public string Box
		{
			get;
			set;
		}

		[XmlElement("branch_shop_name")]
		public string BranchShopName
		{
			get;
			set;
		}

		[XmlElement("brand_logo")]
		public string BrandLogo
		{
			get;
			set;
		}

		[XmlElement("brand_name")]
		public string BrandName
		{
			get;
			set;
		}

		[XmlElement("business_certificate")]
		public string BusinessCertificate
		{
			get;
			set;
		}

		[XmlElement("business_certificate_expires")]
		public string BusinessCertificateExpires
		{
			get;
			set;
		}

		[XmlElement("business_time")]
		public string BusinessTime
		{
			get;
			set;
		}

		[XmlElement("category_id")]
		public string CategoryId
		{
			get;
			set;
		}

		[XmlElement("city_code")]
		public string CityCode
		{
			get;
			set;
		}

		[XmlElement("contact_number")]
		public string ContactNumber
		{
			get;
			set;
		}

		[XmlElement("district_code")]
		public string DistrictCode
		{
			get;
			set;
		}

		[XmlElement("implement_id")]
		public string ImplementId
		{
			get;
			set;
		}

		[XmlElement("is_operating_online")]
		public string IsOperatingOnline
		{
			get;
			set;
		}

		[XmlElement("is_show")]
		public string IsShow
		{
			get;
			set;
		}

		[XmlElement("latitude")]
		public string Latitude
		{
			get;
			set;
		}

		[XmlElement("licence")]
		public string Licence
		{
			get;
			set;
		}

		[XmlElement("licence_code")]
		public string LicenceCode
		{
			get;
			set;
		}

		[XmlElement("licence_expires")]
		public string LicenceExpires
		{
			get;
			set;
		}

		[XmlElement("licence_name")]
		public string LicenceName
		{
			get;
			set;
		}

		[XmlElement("longitude")]
		public string Longitude
		{
			get;
			set;
		}

		[XmlElement("main_image")]
		public string MainImage
		{
			get;
			set;
		}

		[XmlElement("main_shop_name")]
		public string MainShopName
		{
			get;
			set;
		}

		[XmlElement("no_smoking")]
		public string NoSmoking
		{
			get;
			set;
		}

		[XmlElement("notify_mobile")]
		public string NotifyMobile
		{
			get;
			set;
		}

		[XmlElement("online_image")]
		public string OnlineImage
		{
			get;
			set;
		}

		[XmlElement("online_url")]
		public string OnlineUrl
		{
			get;
			set;
		}

		[XmlElement("op_id")]
		public string OpId
		{
			get;
			set;
		}

		[XmlElement("op_role")]
		public string OpRole
		{
			get;
			set;
		}

		[XmlElement("operate_notify_url")]
		public string OperateNotifyUrl
		{
			get;
			set;
		}

		[XmlElement("other_authorization")]
		public string OtherAuthorization
		{
			get;
			set;
		}

		[XmlElement("parking")]
		public string Parking
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("pay_type")]
		public string PayType
		{
			get;
			set;
		}

		[XmlElement("province_code")]
		public string ProvinceCode
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}

		[XmlElement("store_id")]
		public string StoreId
		{
			get;
			set;
		}

		[XmlElement("value_added")]
		public string ValueAdded
		{
			get;
			set;
		}

		[XmlElement("version")]
		public string Version
		{
			get;
			set;
		}

		[XmlElement("wifi")]
		public string Wifi
		{
			get;
			set;
		}
	}
}
