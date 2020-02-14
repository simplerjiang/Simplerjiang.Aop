using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class LawsuitRecord : AopObject
	{
		[XmlArray("ajlc_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> AjlcList
		{
			get;
			set;
		}

		[XmlArray("bgt_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> BgtList
		{
			get;
			set;
		}

		[XmlArray("cpws_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> CpwsList
		{
			get;
			set;
		}

		[XmlArray("fygg_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> FyggList
		{
			get;
			set;
		}

		[XmlArray("ktgg_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> KtggList
		{
			get;
			set;
		}

		[XmlArray("sxgg_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> SxggList
		{
			get;
			set;
		}

		[XmlArray("zxgg_list")]
		[XmlArrayItem("ep_info")]
		public List<EpInfo> ZxggList
		{
			get;
			set;
		}
	}
}
