using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoMycarMerchantshopCommentBatchqueryModel : AopObject
	{
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

		[XmlElement("shop_id")]
		public long ShopId
		{
			get;
			set;
		}
	}
}
