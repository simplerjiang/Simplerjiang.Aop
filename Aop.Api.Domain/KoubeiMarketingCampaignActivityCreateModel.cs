using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class KoubeiMarketingCampaignActivityCreateModel : AopObject
	{
		[XmlElement("auto_delay_flag")]
		public string AutoDelayFlag
		{
			get;
			set;
		}

		[XmlElement("budget_info")]
		public BudgetInfo BudgetInfo
		{
			get;
			set;
		}

		[XmlElement("constraint_info")]
		public ConstraintInfo ConstraintInfo
		{
			get;
			set;
		}

		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("end_time")]
		public string EndTime
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
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

		[XmlElement("operator_id")]
		public string OperatorId
		{
			get;
			set;
		}

		[XmlElement("operator_type")]
		public string OperatorType
		{
			get;
			set;
		}

		[XmlElement("out_biz_no")]
		public string OutBizNo
		{
			get;
			set;
		}

		[XmlArray("promo_tools")]
		[XmlArrayItem("promo_tool")]
		public List<PromoTool> PromoTools
		{
			get;
			set;
		}

		[XmlArray("publish_channels")]
		[XmlArrayItem("publish_channel")]
		public List<PublishChannel> PublishChannels
		{
			get;
			set;
		}

		[XmlElement("recruit_tool")]
		public RecruitTool RecruitTool
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

		[XmlElement("type")]
		public string Type
		{
			get;
			set;
		}
	}
}
