using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantOperatorFreezeResponse : AopResponse
	{
		[XmlElement("result")]
		public bool Result
		{
			get;
			set;
		}
	}
}
