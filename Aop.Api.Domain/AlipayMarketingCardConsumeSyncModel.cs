using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayMarketingCardConsumeSyncModel : AopObject
	{
		[XmlElement("act_pay_amount")]
		public string ActPayAmount
		{
			get;
			set;
		}

		[XmlElement("card_info")]
		public MerchantCard CardInfo
		{
			get;
			set;
		}

		[XmlArray("gain_benefit_list")]
		[XmlArrayItem("benefit_info_detail")]
		public List<BenefitInfoDetail> GainBenefitList
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("shop_code")]
		public string ShopCode
		{
			get;
			set;
		}

		[XmlElement("swipe_cert_type")]
		public string SwipeCertType
		{
			get;
			set;
		}

		[XmlElement("target_card_no")]
		public string TargetCardNo
		{
			get;
			set;
		}

		[XmlElement("target_card_no_type")]
		public string TargetCardNoType
		{
			get;
			set;
		}

		[XmlElement("trade_amount")]
		public string TradeAmount
		{
			get;
			set;
		}

		[XmlElement("trade_name")]
		public string TradeName
		{
			get;
			set;
		}

		[XmlElement("trade_no")]
		public string TradeNo
		{
			get;
			set;
		}

		[XmlElement("trade_time")]
		public string TradeTime
		{
			get;
			set;
		}

		[XmlElement("trade_type")]
		public string TradeType
		{
			get;
			set;
		}

		[XmlArray("use_benefit_list")]
		[XmlArrayItem("benefit_info_detail")]
		public List<BenefitInfoDetail> UseBenefitList
		{
			get;
			set;
		}
	}
}
