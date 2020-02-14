using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantOperatorRoleCreateResponse : AopResponse
	{
		[XmlElement("role_id")]
		public string RoleId
		{
			get;
			set;
		}
	}
}
