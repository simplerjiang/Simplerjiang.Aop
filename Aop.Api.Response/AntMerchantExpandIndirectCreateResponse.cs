using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandIndirectCreateResponse : AopResponse
	{
		[XmlElement("sub_merchant_id")]
		public string SubMerchantId
		{
			get;
			set;
		}
	}
}
