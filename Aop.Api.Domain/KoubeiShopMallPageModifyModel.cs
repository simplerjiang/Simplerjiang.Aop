using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiShopMallPageModifyModel : AopObject
	{
		[XmlElement("mall_id")]
		public string MallId
		{
			get;
			set;
		}

		[XmlElement("mall_url")]
		public string MallUrl
		{
			get;
			set;
		}

		[XmlElement("out_biz_id")]
		public string OutBizId
		{
			get;
			set;
		}
	}
}
