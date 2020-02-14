using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenMiniInneraccountCreateModel : AopObject
	{
		[XmlElement("client_type")]
		public string ClientType
		{
			get;
			set;
		}

		[XmlElement("out_biz_id")]
		public string OutBizId
		{
			get;
			set;
		}
	}
}
