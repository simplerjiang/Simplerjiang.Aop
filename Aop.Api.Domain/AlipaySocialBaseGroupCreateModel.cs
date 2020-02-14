using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseGroupCreateModel : AopObject
	{
		[XmlElement("biz_no")]
		public string BizNo
		{
			get;
			set;
		}

		[XmlElement("biz_type")]
		public string BizType
		{
			get;
			set;
		}

		[XmlElement("group_settings")]
		public GroupSetting GroupSettings
		{
			get;
			set;
		}

		[XmlElement("master_id")]
		public string MasterId
		{
			get;
			set;
		}
	}
}
