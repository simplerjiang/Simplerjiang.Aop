using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayCommerceLotteryPresentSendModel : AopObject
	{
		[XmlElement("alipay_user_id")]
		public string AlipayUserId
		{
			get;
			set;
		}

		[XmlElement("lottery_type_id")]
		public long LotteryTypeId
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}

		[XmlElement("stake_count")]
		public long StakeCount
		{
			get;
			set;
		}

		[XmlElement("swety_words")]
		public string SwetyWords
		{
			get;
			set;
		}
	}
}
