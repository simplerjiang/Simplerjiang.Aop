using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayAssetCardNewtemplateCreateModel : AopObject
	{
		[XmlElement("account_model")]
		public string AccountModel
		{
			get;
			set;
		}

		[XmlElement("assets_code")]
		public string AssetsCode
		{
			get;
			set;
		}

		[XmlElement("biz_from")]
		public string BizFrom
		{
			get;
			set;
		}

		[XmlArray("card_fund_infos")]
		[XmlArrayItem("card_fund_info")]
		public List<CardFundInfo> CardFundInfos
		{
			get;
			set;
		}

		[XmlElement("card_model")]
		public string CardModel
		{
			get;
			set;
		}

		[XmlElement("card_name")]
		public string CardName
		{
			get;
			set;
		}

		[XmlElement("creator")]
		public string Creator
		{
			get;
			set;
		}

		[XmlElement("credit_info")]
		public CardCreditInfo CreditInfo
		{
			get;
			set;
		}

		[XmlElement("extend_info")]
		public string ExtendInfo
		{
			get;
			set;
		}

		[XmlElement("operator")]
		public string Operator
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("period_type")]
		public string PeriodType
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}

		[XmlElement("settle_user_id")]
		public string SettleUserId
		{
			get;
			set;
		}
	}
}
