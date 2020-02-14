using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandOrderQueryResponse : AopResponse
	{
		[XmlElement("apply_time")]
		public string ApplyTime
		{
			get;
			set;
		}

		[XmlArray("ip_role_id")]
		[XmlArrayItem("string")]
		public List<string> IpRoleId
		{
			get;
			set;
		}

		[XmlElement("merchant_name")]
		public string MerchantName
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
