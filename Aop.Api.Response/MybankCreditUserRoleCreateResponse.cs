using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditUserRoleCreateResponse : AopResponse
	{
		[XmlElement("ip_id")]
		public string IpId
		{
			get;
			set;
		}

		[XmlElement("ip_role_id")]
		public string IpRoleId
		{
			get;
			set;
		}
	}
}
