using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozIdentificationCustomerEnrollcertifyQueryResponse : AopResponse
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}
	}
}
