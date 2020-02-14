using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsAutoAutoinsprodPolicyCancelModel : AopObject
	{
		[XmlElement("trade_biz_id")]
		public string TradeBizId
		{
			get;
			set;
		}
	}
}
