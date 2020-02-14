using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoPointReceiveQueryResponse : AopResponse
	{
		[XmlElement("save_amount")]
		public long SaveAmount
		{
			get;
			set;
		}
	}
}
