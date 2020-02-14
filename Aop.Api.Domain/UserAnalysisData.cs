using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class UserAnalysisData : AopObject
	{
		[XmlElement("cancel_user_cnt")]
		public string CancelUserCnt
		{
			get;
			set;
		}

		[XmlElement("cumulate_user_cnt")]
		public string CumulateUserCnt
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

		[XmlElement("grow_user_cnt")]
		public string GrowUserCnt
		{
			get;
			set;
		}

		[XmlElement("new_user_cnt")]
		public string NewUserCnt
		{
			get;
			set;
		}
	}
}
