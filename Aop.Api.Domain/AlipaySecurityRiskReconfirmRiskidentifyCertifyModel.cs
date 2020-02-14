using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskReconfirmRiskidentifyCertifyModel : AopObject
	{
		[XmlElement("account")]
		public string Account
		{
			get;
			set;
		}

		[XmlElement("app_code")]
		public string AppCode
		{
			get;
			set;
		}

		[XmlElement("company")]
		public string Company
		{
			get;
			set;
		}

		[XmlElement("extend_param")]
		public string ExtendParam
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

		[XmlElement("tenant_id_list")]
		public string TenantIdList
		{
			get;
			set;
		}

		[XmlElement("um_id")]
		public string UmId
		{
			get;
			set;
		}

		[XmlElement("um_id_token")]
		public string UmIdToken
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
