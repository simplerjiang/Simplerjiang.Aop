using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditLoanapplyApplyCreateModel : AopObject
	{
		[XmlElement("alipay_id")]
		public string AlipayId
		{
			get;
			set;
		}

		[XmlElement("apply_lmt")]
		public string ApplyLmt
		{
			get;
			set;
		}

		[XmlArray("associate_entitys")]
		[XmlArrayItem("involved_entity")]
		public List<InvolvedEntity> AssociateEntitys
		{
			get;
			set;
		}

		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("biz_scene_no")]
		public string BizSceneNo
		{
			get;
			set;
		}

		[XmlElement("biz_tag")]
		public string BizTag
		{
			get;
			set;
		}

		[XmlElement("cert_no")]
		public string CertNo
		{
			get;
			set;
		}

		[XmlElement("cert_type")]
		public string CertType
		{
			get;
			set;
		}

		[XmlElement("email")]
		public string Email
		{
			get;
			set;
		}

		[XmlElement("ext_par")]
		public string ExtPar
		{
			get;
			set;
		}

		[XmlElement("ip_id")]
		public string IpId
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

		[XmlElement("login_id")]
		public string LoginId
		{
			get;
			set;
		}

		[XmlElement("mobile")]
		public string Mobile
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}

		[XmlElement("op_pd_code")]
		public string OpPdCode
		{
			get;
			set;
		}

		[XmlElement("out_mem_id")]
		public string OutMemId
		{
			get;
			set;
		}

		[XmlElement("out_uni_code")]
		public string OutUniCode
		{
			get;
			set;
		}

		[XmlElement("request_id")]
		public string RequestId
		{
			get;
			set;
		}

		[XmlElement("site")]
		public string Site
		{
			get;
			set;
		}

		[XmlElement("site_user_id")]
		public string SiteUserId
		{
			get;
			set;
		}
	}
}
