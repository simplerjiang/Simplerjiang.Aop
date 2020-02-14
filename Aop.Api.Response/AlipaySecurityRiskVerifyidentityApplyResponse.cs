using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityRiskVerifyidentityApplyResponse : AopResponse
	{
		[XmlElement("err_code")]
		public string ErrCode
		{
			get;
			set;
		}

		[XmlElement("err_message")]
		public string ErrMessage
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

		[XmlElement("unusable_product_list")]
		public string UnusableProductList
		{
			get;
			set;
		}

		[XmlElement("usable_product_group")]
		public string UsableProductGroup
		{
			get;
			set;
		}
	}
}
