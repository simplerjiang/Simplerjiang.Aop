using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	[Serializable]
	public class OfflineInviteNewerSummaryInfoItem
	{
		[XmlElement("report_date")]
		public string ReportDate
		{
			get;
			set;
		}

		[XmlElement("pid")]
		public string Pid
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

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("user_prize_count")]
		public string UserPrizeCount
		{
			get;
			set;
		}

		[XmlElement("user_consume_count")]
		public string UserConsumeCount
		{
			get;
			set;
		}

		[XmlElement("user_cert_count")]
		public string UserCertCount
		{
			get;
			set;
		}

		[XmlElement("user_consume_settle_count")]
		public string UserConsumeSettleCount
		{
			get;
			set;
		}

		[XmlElement("user_cert_settle_count")]
		public string UserCertSettleCount
		{
			get;
			set;
		}

		[XmlElement("user_bind_card_count")]
		public string UserBindCardCount
		{
			get;
			set;
		}

		[XmlElement("user_bind_card_settle_count")]
		public string UserBindCardSettleCount
		{
			get;
			set;
		}
	}
}
