using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayDataDataserviceYuebaoassetDetailSendResponse : AopResponse
	{
		[XmlElement("yeb_asset_data_num")]
		public long YebAssetDataNum
		{
			get;
			set;
		}
	}
}
