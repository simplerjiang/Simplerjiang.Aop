using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFinancialnetAuthContractMerchantSignModel : AopObject
	{
		[XmlElement("account_no")]
		public string AccountNo
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("fee_value")]
		public FeeValue FeeValue
		{
			get;
			set;
		}

		[XmlElement("inst_id")]
		public string InstId
		{
			get;
			set;
		}

		[XmlElement("scene_code")]
		public string SceneCode
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

		[XmlElement("valid_strategy")]
		public ValidStrategy ValidStrategy
		{
			get;
			set;
		}
	}
}
