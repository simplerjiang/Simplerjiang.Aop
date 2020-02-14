using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class MenuAnalysisData : AopObject
	{
		[XmlElement("avg_click_user_cnt")]
		public string AvgClickUserCnt
		{
			get;
			set;
		}

		[XmlElement("click_cnt")]
		public long ClickCnt
		{
			get;
			set;
		}

		[XmlElement("click_user_cnt")]
		public long ClickUserCnt
		{
			get;
			set;
		}

		[XmlElement("date")]
		public string Date
		{
			get;
			set;
		}

		[XmlElement("menu_type")]
		public string MenuType
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

		[XmlElement("sub_name")]
		public string SubName
		{
			get;
			set;
		}
	}
}
