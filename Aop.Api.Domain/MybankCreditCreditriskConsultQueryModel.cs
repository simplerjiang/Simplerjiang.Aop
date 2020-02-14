using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MybankCreditCreditriskConsultQueryModel : AopObject
	{
		[XmlArray("associate_entitys")]
		[XmlArrayItem("involved_entity")]
		public List<InvolvedEntity> AssociateEntitys
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

		[XmlElement("out_uni_code")]
		public string OutUniCode
		{
			get;
			set;
		}

		[XmlElement("pd_code")]
		public string PdCode
		{
			get;
			set;
		}

		[XmlElement("scen")]
		public string Scen
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

		[XmlElement("site_login_id")]
		public string SiteLoginId
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
