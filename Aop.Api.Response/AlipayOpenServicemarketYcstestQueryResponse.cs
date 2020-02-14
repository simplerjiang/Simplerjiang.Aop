using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenServicemarketYcstestQueryResponse : AopResponse
	{
		[XmlElement("out_1")]
		public string Out1
		{
			get;
			set;
		}

		[XmlElement("out_2")]
		public string Out2
		{
			get;
			set;
		}
	}
}
