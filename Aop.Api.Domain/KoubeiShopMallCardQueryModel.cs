using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiShopMallCardQueryModel : AopObject
	{
		[XmlElement("mall_id")]
		public string MallId
		{
			get;
			set;
		}
	}
}
