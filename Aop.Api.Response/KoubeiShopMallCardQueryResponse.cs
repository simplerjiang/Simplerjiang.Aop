using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiShopMallCardQueryResponse : AopResponse
	{
		[XmlArray("cards")]
		[XmlArrayItem("mall_card_bo")]
		public List<MallCardBo> Cards
		{
			get;
			set;
		}

		[XmlElement("open")]
		public bool Open
		{
			get;
			set;
		}

		[XmlElement("open_card_url")]
		public string OpenCardUrl
		{
			get;
			set;
		}
	}
}
