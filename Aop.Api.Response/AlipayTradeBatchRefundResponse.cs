using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeBatchRefundResponse : AopResponse
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}
	}
}
