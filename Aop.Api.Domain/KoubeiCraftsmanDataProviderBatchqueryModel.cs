using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiCraftsmanDataProviderBatchqueryModel : AopObject
	{
		[XmlElement("auth_code")]
		public string AuthCode
		{
			get;
			set;
		}

		[XmlArray("craftsman_ids")]
		[XmlArrayItem("string")]
		public List<string> CraftsmanIds
		{
			get;
			set;
		}

		[XmlArray("out_craftsman_ids")]
		[XmlArrayItem("string")]
		public List<string> OutCraftsmanIds
		{
			get;
			set;
		}

		[XmlElement("page_no")]
		public string PageNo
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public string PageSize
		{
			get;
			set;
		}

		[XmlElement("qr_code_shop_id")]
		public string QrCodeShopId
		{
			get;
			set;
		}

		[XmlElement("recommend")]
		public bool Recommend
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
	}
}
