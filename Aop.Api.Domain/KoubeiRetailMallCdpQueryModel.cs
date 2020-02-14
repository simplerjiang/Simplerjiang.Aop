using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiRetailMallCdpQueryModel : AopObject
	{
		[XmlElement("mall_id")]
		public string MallId
		{
			get;
			set;
		}
	}
}
