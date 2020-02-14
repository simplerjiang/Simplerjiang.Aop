using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandContractFacetofaceQueryResponse : AopResponse
	{
		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("order_detail")]
		public string OrderDetail
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("order_status")]
		public string OrderStatus
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
	}
}
