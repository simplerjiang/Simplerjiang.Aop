using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMicropayOrderDirectPayResponse : AopResponse
	{
		[XmlElement("single_pay_detail")]
		public SinglePayDetail SinglePayDetail
		{
			get;
			set;
		}
	}
}
