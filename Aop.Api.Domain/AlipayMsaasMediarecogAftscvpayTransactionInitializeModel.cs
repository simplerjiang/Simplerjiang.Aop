using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMsaasMediarecogAftscvpayTransactionInitializeModel : AopObject
	{
		[XmlArray("goods_infos")]
		[XmlArrayItem("good_info")]
		public List<GoodInfo> GoodsInfos
		{
			get;
			set;
		}

		[XmlElement("scene")]
		public string Scene
		{
			get;
			set;
		}

		[XmlElement("terminal_id")]
		public string TerminalId
		{
			get;
			set;
		}

		[XmlElement("transaction_id")]
		public string TransactionId
		{
			get;
			set;
		}
	}
}
