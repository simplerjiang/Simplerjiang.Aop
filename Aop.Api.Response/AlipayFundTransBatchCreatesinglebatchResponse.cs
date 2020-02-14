using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransBatchCreatesinglebatchResponse : AopResponse
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("ext_param")]
		public string ExtParam
		{
			get;
			set;
		}

		[XmlElement("token")]
		public string Token
		{
			get;
			set;
		}
	}
}
