using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LotteryPresent : AopObject
	{
		[XmlElement("alipay_user_id")]
		public string AlipayUserId
		{
			get;
			set;
		}

		[XmlElement("lottery_type_name")]
		public string LotteryTypeName
		{
			get;
			set;
		}

		[XmlElement("present_date")]
		public string PresentDate
		{
			get;
			set;
		}

		[XmlElement("present_id")]
		public long PresentId
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

		[XmlElement("status")]
		public long Status
		{
			get;
			set;
		}

		[XmlElement("status_desc")]
		public string StatusDesc
		{
			get;
			set;
		}

		[XmlElement("sweety_words")]
		public string SweetyWords
		{
			get;
			set;
		}

		[XmlElement("win_fee")]
		public long WinFee
		{
			get;
			set;
		}
	}
}
