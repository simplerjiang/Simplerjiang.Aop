using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketingVoucherCodeUploadResponse : AopResponse
	{
		[XmlElement("code_inventory_id")]
		public string CodeInventoryId
		{
			get;
			set;
		}
	}
}
