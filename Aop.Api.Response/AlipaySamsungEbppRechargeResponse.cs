using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySamsungEbppRechargeResponse : AopResponse
	{
		[XmlElement("page_retrun")]
		public string PageRetrun
		{
			get;
			set;
		}
	}
}
