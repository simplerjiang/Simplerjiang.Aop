using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneApplicationGroupApplyResponse : AopResponse
	{
		[XmlElement("application_no")]
		public string ApplicationNo
		{
			get;
			set;
		}

		[XmlElement("operation_id")]
		public string OperationId
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}
	}
}
