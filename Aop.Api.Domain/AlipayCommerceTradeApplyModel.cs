using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceTradeApplyModel : AopObject
	{
		[XmlElement("amount_detail")]
		public string AmountDetail
		{
			get;
			set;
		}

		[XmlElement("channel")]
		public string Channel
		{
			get;
			set;
		}

		[XmlElement("interface_version")]
		public string InterfaceVersion
		{
			get;
			set;
		}

		[XmlElement("op_code")]
		public string OpCode
		{
			get;
			set;
		}

		[XmlElement("order_detail")]
		public string OrderDetail
		{
			get;
			set;
		}

		[XmlElement("scene_code")]
		public string SceneCode
		{
			get;
			set;
		}

		[XmlElement("target_id")]
		public string TargetId
		{
			get;
			set;
		}

		[XmlElement("target_id_type")]
		public string TargetIdType
		{
			get;
			set;
		}

		[XmlElement("trade_apply_params")]
		public TradeApplyParams TradeApplyParams
		{
			get;
			set;
		}
	}
}
