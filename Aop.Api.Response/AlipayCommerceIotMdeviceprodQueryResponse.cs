using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceIotMdeviceprodQueryResponse : AopResponse
	{
		[XmlElement("activate_time")]
		public string ActivateTime
		{
			get;
			set;
		}

		[XmlElement("addr_info")]
		public string AddrInfo
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("device_id")]
		public string DeviceId
		{
			get;
			set;
		}

		[XmlElement("device_name")]
		public string DeviceName
		{
			get;
			set;
		}

		[XmlElement("device_sn")]
		public string DeviceSn
		{
			get;
			set;
		}

		[XmlElement("img_url")]
		public string ImgUrl
		{
			get;
			set;
		}

		[XmlElement("isv")]
		public MerchantModel Isv
		{
			get;
			set;
		}

		[XmlElement("merchant")]
		public MerchantModel Merchant
		{
			get;
			set;
		}

		[XmlElement("shop_address")]
		public string ShopAddress
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

		[XmlElement("shop_name")]
		public string ShopName
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

		[XmlElement("status_desc")]
		public string StatusDesc
		{
			get;
			set;
		}

		[XmlElement("supplier_name")]
		public string SupplierName
		{
			get;
			set;
		}
	}
}
