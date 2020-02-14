using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceDataSendResponse : AopResponse
	{
		[XmlElement("data_send_business_result")]
		public DataSendBusinessResult DataSendBusinessResult
		{
			get;
			set;
		}
	}
}
