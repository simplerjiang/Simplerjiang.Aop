using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppPdeductSignValidateModel : AopObject
	{
		[XmlElement("agent_channel")]
		public string AgentChannel
		{
			get;
			set;
		}

		[XmlElement("agent_code")]
		public string AgentCode
		{
			get;
			set;
		}

		[XmlElement("bill_key")]
		public string BillKey
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("charge_inst")]
		public string ChargeInst
		{
			get;
			set;
		}

		[XmlElement("deduct_type")]
		public string DeductType
		{
			get;
			set;
		}

		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("notify_config")]
		public string NotifyConfig
		{
			get;
			set;
		}

		[XmlElement("out_agreement_id")]
		public string OutAgreementId
		{
			get;
			set;
		}

		[XmlElement("owner_name")]
		public string OwnerName
		{
			get;
			set;
		}

		[XmlElement("pay_config")]
		public string PayConfig
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

		[XmlElement("sign_expire_date")]
		public string SignExpireDate
		{
			get;
			set;
		}

		[XmlElement("sub_biz_type")]
		public string SubBizType
		{
			get;
			set;
		}

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
