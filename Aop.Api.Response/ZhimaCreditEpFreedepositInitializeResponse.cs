using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZhimaCreditEpFreedepositInitializeResponse : AopResponse
	{
		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}
	}
}
