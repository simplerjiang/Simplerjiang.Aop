using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayUserInviteAwardReceiveModel : AopObject
	{
		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("out_biz_code")]
		public string OutBizCode
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
