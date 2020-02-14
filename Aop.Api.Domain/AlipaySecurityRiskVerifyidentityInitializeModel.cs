using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskVerifyidentityInitializeModel : AopObject
	{
		[XmlElement("account_id")]
		public string AccountId
		{
			get;
			set;
		}

		[XmlElement("account_name")]
		public string AccountName
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

		[XmlElement("biz_callback_url")]
		public string BizCallbackUrl
		{
			get;
			set;
		}

		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("biz_params")]
		public string BizParams
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
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
	}
}
