using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditLoanapplyApplyCreateResponse : AopResponse
	{
		[XmlElement("apply_no")]
		public string ApplyNo
		{
			get;
			set;
		}

		[XmlElement("ip_role_id")]
		public string IpRoleId
		{
			get;
			set;
		}

		[XmlElement("sub_apply_no")]
		public string SubApplyNo
		{
			get;
			set;
		}
	}
}
