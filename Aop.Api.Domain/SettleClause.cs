using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SettleClause : AopObject
	{
		[XmlElement("amount")]
		public string Amount
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

		[XmlElement("settle_account_id")]
		public string SettleAccountId
		{
			get;
			set;
		}

		[XmlElement("settle_account_id_type")]
		public string SettleAccountIdType
		{
			get;
			set;
		}

		[XmlElement("settle_account_type")]
		public string SettleAccountType
		{
			get;
			set;
		}

		[XmlElement("settle_entity_id")]
		public string SettleEntityId
		{
			get;
			set;
		}

		[XmlElement("settle_entity_type")]
		public string SettleEntityType
		{
			get;
			set;
		}
	}
}
