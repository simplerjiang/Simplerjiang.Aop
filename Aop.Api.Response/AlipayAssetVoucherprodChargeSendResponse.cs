using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayAssetVoucherprodChargeSendResponse : AopResponse
	{
		[XmlElement("asset_instance_id")]
		public string AssetInstanceId
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}
	}
}
