using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEcoRenthouseBookInfo : AopObject
	{
		[XmlElement("book_amount")]
		public string BookAmount
		{
			get;
			set;
		}

		[XmlElement("book_sale_amount")]
		public string BookSaleAmount
		{
			get;
			set;
		}

		[XmlElement("latest_signing_date")]
		public string LatestSigningDate
		{
			get;
			set;
		}

		[XmlElement("lease_begin_date")]
		public string LeaseBeginDate
		{
			get;
			set;
		}

		[XmlElement("lease_end_date")]
		public string LeaseEndDate
		{
			get;
			set;
		}

		[XmlElement("remark")]
		public string Remark
		{
			get;
			set;
		}
	}
}
