using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketShopPublicBindResponse : AopResponse
	{
		[XmlArray("error_binding_shop_ids")]
		[XmlArrayItem("string")]
		public List<string> ErrorBindingShopIds
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
