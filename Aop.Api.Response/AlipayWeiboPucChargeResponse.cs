using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayWeiboPucChargeResponse : AopResponse
	{
		[XmlElement("partnerpuccharge")]
		public string Partnerpuccharge
		{
			get;
			set;
		}
	}
}
