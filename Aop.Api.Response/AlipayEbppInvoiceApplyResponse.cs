using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceApplyResponse : AopResponse
	{
		[XmlElement("apply_id")]
		public string ApplyId
		{
			get;
			set;
		}
	}
}
