using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsAutoAutoinsprodPolicyCancelResponse : AopResponse
	{
		[XmlElement("cancel_result")]
		public string CancelResult
		{
			get;
			set;
		}
	}
}
