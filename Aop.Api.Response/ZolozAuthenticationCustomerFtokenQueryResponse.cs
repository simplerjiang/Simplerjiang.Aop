using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozAuthenticationCustomerFtokenQueryResponse : AopResponse
	{
		[XmlElement("authimg_base_64")]
		public string AuthimgBase64
		{
			get;
			set;
		}

		[XmlElement("uid")]
		public string Uid
		{
			get;
			set;
		}

		[XmlArray("uid_tel_pair_list")]
		[XmlArrayItem("zhub_uid_tel_pair")]
		public List<ZhubUidTelPair> UidTelPairList
		{
			get;
			set;
		}
	}
}
