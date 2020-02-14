using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class SignTask : AopObject
	{
		[XmlElement("biz_data")]
		public string BizData
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

		[XmlElement("cb_type")]
		public string CbType
		{
			get;
			set;
		}

		[XmlElement("cb_url")]
		public string CbUrl
		{
			get;
			set;
		}

		[XmlElement("cert_sign_type")]
		public long CertSignType
		{
			get;
			set;
		}

		[XmlElement("enter_type")]
		public string EnterType
		{
			get;
			set;
		}

		[XmlArray("principal_list")]
		[XmlArrayItem("principal")]
		public List<Principal> PrincipalList
		{
			get;
			set;
		}

		[XmlElement("signer_type")]
		public string SignerType
		{
			get;
			set;
		}

		[XmlElement("task_expire")]
		public string TaskExpire
		{
			get;
			set;
		}
	}
}
