using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOperatorMobileBindResponse : AopResponse
	{
		[XmlElement("alipay_user_id")]
		public string AlipayUserId
		{
			get;
			set;
		}

		[XmlElement("certificate")]
		public string Certificate
		{
			get;
			set;
		}

		[XmlElement("mobile_no")]
		public string MobileNo
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

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}
