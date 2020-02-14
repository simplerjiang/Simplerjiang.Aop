using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserValidateResponse : AopResponse
	{
		[XmlElement("alipay_user_id")]
		public string AlipayUserId
		{
			get;
			set;
		}

		[XmlElement("certified")]
		public string Certified
		{
			get;
			set;
		}

		[XmlElement("real_name")]
		public string RealName
		{
			get;
			set;
		}
	}
}
