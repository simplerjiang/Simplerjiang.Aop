using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceLogisticsFaceMatchResponse : AopResponse
	{
		[XmlElement("biz_unique_no")]
		public string BizUniqueNo
		{
			get;
			set;
		}
	}
}
