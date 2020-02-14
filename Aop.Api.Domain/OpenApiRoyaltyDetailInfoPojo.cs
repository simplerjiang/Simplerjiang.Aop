using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class OpenApiRoyaltyDetailInfoPojo : AopObject
	{
		[XmlElement("amount")]
		public long Amount
		{
			get;
			set;
		}

		[XmlElement("amount_percentage")]
		public long AmountPercentage
		{
			get;
			set;
		}

		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("royalty_type")]
		public string RoyaltyType
		{
			get;
			set;
		}

		[XmlElement("trans_in")]
		public string TransIn
		{
			get;
			set;
		}

		[XmlElement("trans_in_type")]
		public string TransInType
		{
			get;
			set;
		}

		[XmlElement("trans_out")]
		public string TransOut
		{
			get;
			set;
		}

		[XmlElement("trans_out_type")]
		public string TransOutType
		{
			get;
			set;
		}
	}
}
