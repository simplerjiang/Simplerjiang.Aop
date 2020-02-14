using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransAacollectBatchCloseResponse : AopResponse
	{
		[XmlElement("batch_status")]
		public string BatchStatus
		{
			get;
			set;
		}
	}
}
