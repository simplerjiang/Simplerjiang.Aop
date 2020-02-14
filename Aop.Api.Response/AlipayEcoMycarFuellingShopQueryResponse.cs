using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarFuellingShopQueryResponse : AopResponse
	{
		[XmlElement("address")]
		public string Address
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

		[XmlElement("district_code")]
		public string DistrictCode
		{
			get;
			set;
		}

		[XmlElement("lat")]
		public string Lat
		{
			get;
			set;
		}

		[XmlElement("lon")]
		public string Lon
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

		[XmlElement("pay_url")]
		public string PayUrl
		{
			get;
			set;
		}

		[XmlElement("poi_id")]
		public string PoiId
		{
			get;
			set;
		}

		[XmlArray("product")]
		[XmlArrayItem("product")]
		public List<Product> Product
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

		[XmlArray("sale")]
		[XmlArrayItem("sale")]
		public List<Sale> Sale
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

		[XmlElement("shop_status")]
		public string ShopStatus
		{
			get;
			set;
		}
	}
}
