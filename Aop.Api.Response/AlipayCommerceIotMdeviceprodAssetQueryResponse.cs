using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceIotMdeviceprodAssetQueryResponse : AopResponse
	{
		[XmlElement("image_url")]
		public string ImageUrl
		{
			get;
			set;
		}

		[XmlElement("item_name")]
		public string ItemName
		{
			get;
			set;
		}
	}
}
