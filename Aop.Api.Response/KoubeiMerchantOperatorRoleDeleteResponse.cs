using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantOperatorRoleDeleteResponse : AopResponse
	{
		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
