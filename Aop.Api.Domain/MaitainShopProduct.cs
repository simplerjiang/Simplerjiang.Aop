using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MaitainShopProduct : AopObject
	{
		[XmlElement("off_price")]
		public string OffPrice
		{
			get;
			set;
		}

		[XmlElement("orig_price")]
		public string OrigPrice
		{
			get;
			set;
		}

		[XmlElement("out_privilege_id")]
		public string OutPrivilegeId
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

		[XmlElement("privilege_close_time")]
		public string PrivilegeCloseTime
		{
			get;
			set;
		}

		[XmlElement("privilege_price")]
		public string PrivilegePrice
		{
			get;
			set;
		}

		[XmlElement("privilege_start_time")]
		public string PrivilegeStartTime
		{
			get;
			set;
		}

		[XmlElement("privilege_tags")]
		public string PrivilegeTags
		{
			get;
			set;
		}

		[XmlElement("product_desc")]
		public string ProductDesc
		{
			get;
			set;
		}

		[XmlElement("product_name")]
		public string ProductName
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

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
