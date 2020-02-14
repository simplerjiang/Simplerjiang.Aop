using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileStdPublicMessageMatcherSendResponse : AopResponse
	{
		[XmlElement("to_alipay_user_id")]
		public string ToAlipayUserId
		{
			get;
			set;
		}

		[XmlElement("to_user_id")]
		public string ToUserId
		{
			get;
			set;
		}
	}
}
