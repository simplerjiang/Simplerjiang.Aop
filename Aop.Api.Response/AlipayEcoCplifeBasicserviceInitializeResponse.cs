using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeBasicserviceInitializeResponse : AopResponse
	{
		[XmlElement("bill_pay_auth_url")]
		public string BillPayAuthUrl
		{
			get;
			set;
		}

		[XmlElement("next_action")]
		public string NextAction
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
