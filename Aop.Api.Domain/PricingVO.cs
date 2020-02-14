using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PricingVO : AopObject
	{
		[XmlElement("bid")]
		public string Bid
		{
			get;
			set;
		}

		[XmlElement("currency")]
		public string Currency
		{
			get;
			set;
		}

		[XmlElement("currency_unit")]
		public long CurrencyUnit
		{
			get;
			set;
		}

		[XmlElement("expiry_timestamp")]
		public string ExpiryTimestamp
		{
			get;
			set;
		}

		[XmlElement("generate_timestamp")]
		public string GenerateTimestamp
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

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("mid")]
		public string Mid
		{
			get;
			set;
		}

		[XmlElement("minimum_bid_amount")]
		public long MinimumBidAmount
		{
			get;
			set;
		}

		[XmlElement("minimum_offer_amount")]
		public long MinimumOfferAmount
		{
			get;
			set;
		}

		[XmlElement("offer")]
		public string Offer
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

		[XmlElement("rate_reference_id")]
		public string RateReferenceId
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

		[XmlElement("spot_bid")]
		public string SpotBid
		{
			get;
			set;
		}

		[XmlElement("spot_mid")]
		public string SpotMid
		{
			get;
			set;
		}

		[XmlElement("spot_offer")]
		public string SpotOffer
		{
			get;
			set;
		}

		[XmlElement("start_timestamp")]
		public string StartTimestamp
		{
			get;
			set;
		}

		[XmlElement("symbol")]
		public string Symbol
		{
			get;
			set;
		}

		[XmlElement("threshold_timestamp")]
		public string ThresholdTimestamp
		{
			get;
			set;
		}

		[XmlElement("valid_timestamp")]
		public string ValidTimestamp
		{
			get;
			set;
		}
	}
}
