using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class InsCertificateApiDTO : AopObject
	{
		[XmlElement("biz_data")]
		public string BizData
		{
			get;
			set;
		}

		[XmlElement("certificate_no")]
		public string CertificateNo
		{
			get;
			set;
		}

		[XmlElement("certificate_type")]
		public string CertificateType
		{
			get;
			set;
		}

		[XmlElement("effect_time")]
		public string EffectTime
		{
			get;
			set;
		}

		[XmlElement("expire_time")]
		public string ExpireTime
		{
			get;
			set;
		}

		[XmlElement("face_value")]
		public string FaceValue
		{
			get;
			set;
		}

		[XmlElement("ins_policy_no")]
		public string InsPolicyNo
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

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}

		[XmlElement("order_source")]
		public string OrderSource
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlElement("owner_uid")]
		public string OwnerUid
		{
			get;
			set;
		}

		[XmlElement("status")]
		public long Status
		{
			get;
			set;
		}

		[XmlElement("use_time")]
		public string UseTime
		{
			get;
			set;
		}

		[XmlElement("user_uid")]
		public string UserUid
		{
			get;
			set;
		}
	}
}
