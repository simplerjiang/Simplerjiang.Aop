using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsDataAutoCoefficientSyncResponse : AopResponse
	{
		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}
	}
}
