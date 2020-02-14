using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransAacollectBatchCreateResponse : AopResponse
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("batch_token")]
		public string BatchToken
		{
			get;
			set;
		}
	}
}
