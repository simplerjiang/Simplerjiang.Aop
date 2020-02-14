using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFundStudentloanRepayQueryResponse : AopResponse
	{
		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("branch_name")]
		public string BranchName
		{
			get;
			set;
		}

		[XmlElement("org_name")]
		public string OrgName
		{
			get;
			set;
		}

		[XmlElement("repay_date")]
		public string RepayDate
		{
			get;
			set;
		}

		[XmlArray("repay_list")]
		[XmlArrayItem("repay_detail")]
		public List<RepayDetail> RepayList
		{
			get;
			set;
		}

		[XmlElement("should_amount")]
		public string ShouldAmount
		{
			get;
			set;
		}

		[XmlElement("student_name")]
		public string StudentName
		{
			get;
			set;
		}
	}
}
