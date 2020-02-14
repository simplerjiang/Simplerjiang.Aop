using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayInsSceneClaimApplyModel : AopObject
	{
		[XmlElement("accident_address")]
		public string AccidentAddress
		{
			get;
			set;
		}

		[XmlElement("accident_desc")]
		public string AccidentDesc
		{
			get;
			set;
		}

		[XmlElement("accident_time")]
		public string AccidentTime
		{
			get;
			set;
		}

		[XmlElement("beneficiary")]
		public InsPerson Beneficiary
		{
			get;
			set;
		}

		[XmlElement("bill_title")]
		public string BillTitle
		{
			get;
			set;
		}

		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("claim_fee")]
		public long ClaimFee
		{
			get;
			set;
		}

		[XmlArray("claim_policy_list")]
		[XmlArrayItem("ins_claim_policy")]
		public List<InsClaimPolicy> ClaimPolicyList
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

		[XmlElement("out_request_no")]
		public string OutRequestNo
		{
			get;
			set;
		}

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}

		[XmlElement("reporter")]
		public InsPerson Reporter
		{
			get;
			set;
		}
	}
}
