using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceTransportOfflinepayKeyQueryResponse : AopResponse
	{
		[XmlArray("keys")]
		[XmlArrayItem("alipay_offline_pay_master_key")]
		public List<AlipayOfflinePayMasterKey> Keys
		{
			get;
			set;
		}
	}
}
