using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppInvoiceApplyResultSyncResponse : AopResponse
	{
		[XmlElement("retry_flag")]
		public bool RetryFlag
		{
			get;
			set;
		}
	}
}
