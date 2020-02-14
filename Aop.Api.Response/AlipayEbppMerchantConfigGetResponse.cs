using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppMerchantConfigGetResponse : AopResponse
	{
		[XmlArray("inst_configs")]
		[XmlArrayItem("merchant_inst_config")]
		public List<MerchantInstConfig> InstConfigs
		{
			get;
			set;
		}

		[XmlElement("merchant_user_id")]
		public string MerchantUserId
		{
			get;
			set;
		}
	}
}
