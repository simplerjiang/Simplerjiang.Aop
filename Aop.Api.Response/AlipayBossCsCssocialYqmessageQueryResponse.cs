using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayBossCsCssocialYqmessageQueryResponse : AopResponse
	{
		[XmlElement("data")]
		public string Data
		{
			get;
			set;
		}
	}
}
