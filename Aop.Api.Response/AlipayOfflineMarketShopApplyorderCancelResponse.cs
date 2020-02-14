using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOfflineMarketShopApplyorderCancelResponse : AopResponse
	{
		[XmlElement("apply_id")]
		public string ApplyId
		{
			get;
			set;
		}
	}
}
