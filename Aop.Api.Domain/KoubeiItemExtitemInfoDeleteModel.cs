using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiItemExtitemInfoDeleteModel : AopObject
	{
		[XmlElement("goods_id")]
		public string GoodsId
		{
			get;
			set;
		}
	}
}
