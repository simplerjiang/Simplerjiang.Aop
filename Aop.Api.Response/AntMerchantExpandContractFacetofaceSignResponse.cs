using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandContractFacetofaceSignResponse : AopResponse
	{
		[XmlElement("order_no")]
		public string OrderNo
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
