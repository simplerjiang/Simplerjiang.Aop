using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayTradeBatchSettleResponse : AopResponse
	{
		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("settle_no")]
		public string SettleNo
		{
			get;
			set;
		}
	}
}
