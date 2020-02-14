using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantOperatorModifyResponse : AopResponse
	{
		[XmlElement("operator_id")]
		public string OperatorId
		{
			get;
			set;
		}
	}
}
