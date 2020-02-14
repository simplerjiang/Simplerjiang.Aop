using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketShopPublicUnbindResponse : AopResponse
	{
		[XmlArray("error_un_binding_shop_ids")]
		[XmlArrayItem("string")]
		public List<string> ErrorUnBindingShopIds
		{
			get;
			set;
		}

		[XmlElement("total_error")]
		public long TotalError
		{
			get;
			set;
		}

		[XmlElement("total_success")]
		public long TotalSuccess
		{
			get;
			set;
		}
	}
}
