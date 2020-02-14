using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketProductBatchqueryModel : AopObject
	{
		[XmlElement("op_role")]
		public string OpRole
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

		[XmlElement("shop_id")]
		public string ShopId
		{
			get;
			set;
		}
	}
}
