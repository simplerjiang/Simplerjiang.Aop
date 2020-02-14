using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundTransAacollectPayorderCreateResponse : AopResponse
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("transfer_no")]
		public string TransferNo
		{
			get;
			set;
		}
	}
}
