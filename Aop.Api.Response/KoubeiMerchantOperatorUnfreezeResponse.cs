using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantOperatorUnfreezeResponse : AopResponse
	{
		[XmlElement("result")]
		public bool Result
		{
			get;
			set;
		}
	}
}
