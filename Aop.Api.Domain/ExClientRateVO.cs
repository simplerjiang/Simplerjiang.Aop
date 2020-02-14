using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ExClientRateVO : AopObject
	{
		[XmlElement("agreement_id")]
		public string AgreementId
		{
			get;
			set;
		}

		[XmlElement("base_ccy")]
		public string BaseCcy
		{
			get;
			set;
		}

		[XmlElement("bid_rate")]
		public string BidRate
		{
			get;
			set;
		}

		[XmlElement("client_bid_rate")]
		public string ClientBidRate
		{
			get;
			set;
		}

		[XmlElement("client_id")]
		public string ClientId
		{
			get;
			set;
		}

		[XmlElement("client_offer_rate")]
		public string ClientOfferRate
		{
			get;
			set;
		}

		[XmlElement("currency_pair")]
		public string CurrencyPair
		{
			get;
			set;
		}

		[XmlElement("expiry_time")]
		public string ExpiryTime
		{
			get;
			set;
		}

		[XmlElement("generate_date")]
		public string GenerateDate
		{
			get;
			set;
		}

		[XmlElement("generate_time")]
		public string GenerateTime
		{
			get;
			set;
		}

		[XmlElement("guaranteed")]
		public string Guaranteed
		{
			get;
			set;
		}

		[XmlElement("maturity_date")]
		public string MaturityDate
		{
			get;
			set;
		}

		[XmlElement("maximum_bid_amount")]
		public long MaximumBidAmount
		{
			get;
			set;
		}

		[XmlElement("maximum_offer_amount")]
		public long MaximumOfferAmount
		{
			get;
			set;
		}

		[XmlElement("mid_rate")]
		public string MidRate
		{
			get;
			set;
		}

		[XmlElement("minimum_bid_amount")]
		public string MinimumBidAmount
		{
			get;
			set;
		}

		[XmlElement("minimum_offer_amount")]
		public string MinimumOfferAmount
		{
			get;
			set;
		}

		[XmlElement("offer_rate")]
		public string OfferRate
		{
			get;
			set;
		}

		[XmlElement("on_off_shore")]
		public string OnOffShore
		{
			get;
			set;
		}

		[XmlElement("origin_rate_inst")]
		public string OriginRateInst
		{
			get;
			set;
		}

		[XmlElement("origin_rate_ref")]
		public string OriginRateRef
		{
			get;
			set;
		}

		[XmlElement("period")]
		public string Period
		{
			get;
			set;
		}

		[XmlElement("profile_id")]
		public string ProfileId
		{
			get;
			set;
		}

		[XmlElement("quote_ccy")]
		public string QuoteCcy
		{
			get;
			set;
		}

		[XmlElement("rate_ref")]
		public string RateRef
		{
			get;
			set;
		}

		[XmlElement("rate_time")]
		public string RateTime
		{
			get;
			set;
		}

		[XmlElement("rate_type")]
		public string RateType
		{
			get;
			set;
		}

		[XmlElement("sp_bid")]
		public string SpBid
		{
			get;
			set;
		}

		[XmlElement("sp_mid")]
		public string SpMid
		{
			get;
			set;
		}

		[XmlElement("sp_offer")]
		public string SpOffer
		{
			get;
			set;
		}

		[XmlElement("standard_product_rate_id")]
		public string StandardProductRateId
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}

		[XmlElement("sub_agreement_id")]
		public string SubAgreementId
		{
			get;
			set;
		}

		[XmlElement("threshold_time")]
		public string ThresholdTime
		{
			get;
			set;
		}

		[XmlElement("time_zone")]
		public string TimeZone
		{
			get;
			set;
		}

		[XmlElement("transaction_ccy_type")]
		public string TransactionCcyType
		{
			get;
			set;
		}

		[XmlElement("valid_time")]
		public string ValidTime
		{
			get;
			set;
		}
	}
}
