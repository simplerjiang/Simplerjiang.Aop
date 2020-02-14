using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CompanyRole : AopObject
	{
		[XmlArray("ry_pos_fr_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> RyPosFrList
		{
			get;
			set;
		}

		[XmlArray("ry_pos_sha_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> RyPosShaList
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
