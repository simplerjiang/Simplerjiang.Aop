using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RecruitTool : AopObject
	{
		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("exclude_constraint_shops")]
		public bool ExcludeConstraintShops
		{
			get;
			set;
		}

		[XmlArray("pid_shops")]
		[XmlArrayItem("pid_shop_info")]
		public List<PidShopInfo> PidShops
		{
			get;
			set;
		}

		[XmlElement("start_time")]
		public string StartTime
		{
			get;
			set;
		}
	}
}
