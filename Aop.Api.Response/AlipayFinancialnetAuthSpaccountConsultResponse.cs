using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayFinancialnetAuthSpaccountConsultResponse : AopResponse
	{
		[XmlElement("display_opened_account_logon_id")]
		public string DisplayOpenedAccountLogonId
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
		public bool IsSuccess
		{
			get;
			set;
		}

		[XmlElement("opened_account")]
		public bool OpenedAccount
		{
			get;
			set;
		}

		[XmlElement("opened_account_user_id")]
		public string OpenedAccountUserId
		{
			get;
			set;
		}
	}
}
