using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayWeiboEbppRechargeResponse : AopResponse
	{
		[XmlElement("partnerpuccharge")]
		public string Partnerpuccharge
		{
			get;
			set;
		}
	}
}
