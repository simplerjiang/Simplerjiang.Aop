using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySecurityRiskReconfirmVerificatecallbackSendModel : AopObject
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

		[XmlElement("extend_param")]
		public string ExtendParam
		{
			get;
			set;
		}

		[XmlElement("identify_id")]
		public string IdentifyId
		{
			get;
			set;
		}

		[XmlElement("reauth_type")]
		public string ReauthType
		{
			get;
			set;
		}

		[XmlElement("reconfirm_result")]
		public bool ReconfirmResult
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
