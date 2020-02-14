using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandMerchantStorelistQueryResponse : AopResponse
	{
		[XmlArray("merchant_stores")]
		[XmlArrayItem("shop_query_info")]
		public List<ShopQueryInfo> MerchantStores
		{
			get;
			set;
		}

		[XmlElement("page_num")]
		public long PageNum
		{
			get;
			set;
		}

		[XmlElement("page_size")]
		public long PageSize
		{
			get;
			set;
		}

		[XmlElement("total_pages")]
		public long TotalPages
		{
			get;
			set;
		}

		[XmlElement("total_size")]
		public long TotalSize
		{
			get;
			set;
		}
	}
}
