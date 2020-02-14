using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SettleCardInfo : AopObject
	{
		[XmlElement("account_branch_name")]
		public string AccountBranchName
		{
			get;
			set;
		}

		[XmlElement("account_holder_name")]
		public string AccountHolderName
		{
			get;
			set;
		}

		[XmlElement("account_inst_city")]
		public string AccountInstCity
		{
			get;
			set;
		}

		[XmlElement("account_inst_id")]
		public string AccountInstId
		{
			get;
			set;
		}

		[XmlElement("account_inst_name")]
		public string AccountInstName
		{
			get;
			set;
		}

		[XmlElement("account_inst_province")]
		public string AccountInstProvince
		{
			get;
			set;
		}

		[XmlElement("account_no")]
		public string AccountNo
		{
			get;
			set;
		}

		[XmlElement("account_type")]
		public string AccountType
		{
			get;
			set;
		}

		[XmlElement("bank_code")]
		public string BankCode
		{
			get;
			set;
		}

		[XmlElement("usage_type")]
		public string UsageType
		{
			get;
			set;
		}
	}
}
