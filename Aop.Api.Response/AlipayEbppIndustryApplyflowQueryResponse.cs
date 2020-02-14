using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppIndustryApplyflowQueryResponse : AopResponse
	{
		[XmlElement("ability_code")]
		public string AbilityCode
		{
			get;
			set;
		}

		[XmlElement("apply_flow_no")]
		public string ApplyFlowNo
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

		[XmlElement("biz_inst")]
		public string BizInst
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

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("org_result_code")]
		public string OrgResultCode
		{
			get;
			set;
		}

		[XmlElement("out_apply_no")]
		public string OutApplyNo
		{
			get;
			set;
		}

		[XmlElement("result_code")]
		public string ResultCode
		{
			get;
			set;
		}

		[XmlElement("result_context")]
		public string ResultContext
		{
			get;
			set;
		}

		[XmlElement("result_msg")]
		public string ResultMsg
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
