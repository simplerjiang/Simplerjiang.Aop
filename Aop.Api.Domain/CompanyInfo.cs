using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CompanyInfo : AopObject
	{
		[XmlArray("alter_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> AlterList
		{
			get;
			set;
		}

		[XmlElement("basic_info")]
		public EpInfo BasicInfo
		{
			get;
			set;
		}

		[XmlArray("case_info_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> CaseInfoList
		{
			get;
			set;
		}

		[XmlArray("entinv_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> EntinvList
		{
			get;
			set;
		}

		[XmlArray("fr_position_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> FrPositionList
		{
			get;
			set;
		}

		[XmlArray("frinv_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> FrinvList
		{
			get;
			set;
		}

		[XmlArray("person_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> PersonList
		{
			get;
			set;
		}

		[XmlArray("share_holder_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> ShareHolderList
		{
			get;
			set;
		}
	}
}
