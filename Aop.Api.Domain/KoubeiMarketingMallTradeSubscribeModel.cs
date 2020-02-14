using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingMallTradeSubscribeModel : AopObject
	{
		[XmlElement("card_template_id")]
		public string CardTemplateId
		{
			get;
			set;
		}

		[XmlElement("mall_id")]
		public string MallId
		{
			get;
			set;
		}
	}
}
