using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobileShakeUserQueryResponse : AopResponse
	{
		[XmlElement("bizdata")]
		public string Bizdata
		{
			get;
			set;
		}

		[XmlElement("logon_id")]
		public string LogonId
		{
			get;
			set;
		}

		[XmlElement("pass_id")]
		public string PassId
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
