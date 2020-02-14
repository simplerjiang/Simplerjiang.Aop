using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOfflineMarketShopApplyorderCancelModel : AopObject
	{
		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("op_id")]
		public string OpId
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}
	}
}
