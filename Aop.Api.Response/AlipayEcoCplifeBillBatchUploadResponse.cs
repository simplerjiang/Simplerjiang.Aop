using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoCplifeBillBatchUploadResponse : AopResponse
	{
		[XmlElement("batch_id")]
		public string BatchId
		{
			get;
			set;
		}
	}
}
