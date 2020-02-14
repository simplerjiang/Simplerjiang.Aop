using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicMessageMatcherSendResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlElement("msg")]
		public new string Msg
		{
			get;
			set;
		}

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
