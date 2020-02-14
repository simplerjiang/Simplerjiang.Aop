using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankFinanceYulibaoCapitalPurchaseResponse : AopResponse
	{
		[XmlElement("inner_biz_no")]
		public string InnerBizNo
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}

		[XmlElement("trans_result")]
		public string TransResult
		{
			get;
			set;
		}
	}
}
