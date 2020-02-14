using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicLifeAgentcreateQueryResponse : AopResponse
	{
		[XmlElement("life_app_id")]
		public string LifeAppId
		{
			get;
			set;
		}

		[XmlElement("merchant_pid")]
		public string MerchantPid
		{
			get;
			set;
		}

		[XmlElement("order_status_biz_desc")]
		public string OrderStatusBizDesc
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

		[XmlElement("refused_reason")]
		public string RefusedReason
		{
			get;
			set;
		}
	}
}
