using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CampDetail : AopObject
	{
		[XmlArray("activity_orders")]
		[XmlArrayItem("activity_order_d_t_o")]
		public List<ActivityOrderDTO> ActivityOrders
		{
			get;
			set;
		}

		[XmlElement("audit_status")]
		public string AuditStatus
		{
			get;
			set;
		}

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

		[XmlElement("id")]
		public string Id
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

		[XmlElement("recruit_info")]
		public RecruitInfo RecruitInfo
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

		[XmlElement("status")]
		public string Status
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
