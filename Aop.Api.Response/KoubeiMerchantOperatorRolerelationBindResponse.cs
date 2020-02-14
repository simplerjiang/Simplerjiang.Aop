using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantOperatorRolerelationBindResponse : AopResponse
	{
		[XmlElement("success")]
		public bool Success
		{
			get;
			set;
		}
	}
}
