using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketShopBatchqueryModel : AopObject
	{
		[XmlElement("page_no")]
		public string PageNo
		{
			get;
			set;
		}
	}
}
