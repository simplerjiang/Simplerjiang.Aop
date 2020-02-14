using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFinancialnetAuthSpaccountQueryResponse : AopResponse
	{
		[XmlArray("account_info")]
		[XmlArrayItem("sp_account_info")]
		public List<SpAccountInfo> AccountInfo
		{
			get;
			set;
		}

		[XmlElement("error_code")]
		public string ErrorCode
		{
			get;
			set;
		}

		[XmlElement("error_message")]
		public string ErrorMessage
		{
			get;
			set;
		}

		[XmlElement("is_success")]
		public string IsSuccess
		{
			get;
			set;
		}
	}
}
