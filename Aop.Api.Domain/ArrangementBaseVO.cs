using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ArrangementBaseVO : AopObject
	{
		[XmlElement("app_id")]
		public string AppId
		{
			get;
			set;
		}

		[XmlElement("arrangement_institution_code")]
		public string ArrangementInstitutionCode
		{
			get;
			set;
		}

		[XmlElement("arrangement_name")]
		public string ArrangementName
		{
			get;
			set;
		}

		[XmlElement("arrangement_no")]
		public string ArrangementNo
		{
			get;
			set;
		}

		[XmlElement("arrangement_type")]
		public string ArrangementType
		{
			get;
			set;
		}

		[XmlElement("arrangement_version")]
		public string ArrangementVersion
		{
			get;
			set;
		}

		[XmlElement("channel_code")]
		public string ChannelCode
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("gmt_expired")]
		public string GmtExpired
		{
			get;
			set;
		}

		[XmlElement("gmt_invalid_due")]
		public string GmtInvalidDue
		{
			get;
			set;
		}

		[XmlElement("gmt_sign")]
		public string GmtSign
		{
			get;
			set;
		}

		[XmlElement("gmt_vald_due")]
		public string GmtValdDue
		{
			get;
			set;
		}

		[XmlElement("gmt_vrsn")]
		public string GmtVrsn
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

		[XmlElement("last_moder")]
		public string LastModer
		{
			get;
			set;
		}

		[XmlElement("mark_type")]
		public string MarkType
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("moder_type")]
		public string ModerType
		{
			get;
			set;
		}

		[XmlElement("pd_mark")]
		public string PdMark
		{
			get;
			set;
		}

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}

		[XmlElement("prod_name")]
		public string ProdName
		{
			get;
			set;
		}

		[XmlElement("prod_version")]
		public string ProdVersion
		{
			get;
			set;
		}

		[XmlElement("ps_code")]
		public string PsCode
		{
			get;
			set;
		}

		[XmlElement("ps_id")]
		public string PsId
		{
			get;
			set;
		}

		[XmlElement("ps_name")]
		public string PsName
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}

		[XmlElement("template_prod_code")]
		public string TemplateProdCode
		{
			get;
			set;
		}

		[XmlElement("template_prod_version")]
		public string TemplateProdVersion
		{
			get;
			set;
		}
	}
}
