using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenAppYiyiyiwuQueryResponse : AopResponse
	{
		[XmlElement("chucan")]
		public string Chucan
		{
			get;
			set;
		}
	}
}
