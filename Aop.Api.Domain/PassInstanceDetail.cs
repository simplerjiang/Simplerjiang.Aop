using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class PassInstanceDetail : AopObject
	{
		[XmlArray("biz_param_list")]
		[XmlArrayItem("biz_param_key_value")]
		public List<BizParamKeyValue> BizParamList
		{
			get;
			set;
		}

		[XmlElement("channel_id")]
		public string ChannelId
		{
			get;
			set;
		}

		[XmlElement("create_time")]
		public string CreateTime
		{
			get;
			set;
		}

		[XmlElement("end_date")]
		public string EndDate
		{
			get;
			set;
		}

		[XmlElement("is_deleted")]
		public bool IsDeleted
		{
			get;
			set;
		}

		[XmlElement("logo")]
		public string Logo
		{
			get;
			set;
		}

		[XmlElement("logo_text")]
		public string LogoText
		{
			get;
			set;
		}

		[XmlElement("modify_time")]
		public string ModifyTime
		{
			get;
			set;
		}

		[XmlElement("pass_id")]
		public string PassId
		{
			get;
			set;
		}

		[XmlElement("product")]
		public string Product
		{
			get;
			set;
		}

		[XmlElement("serial_number")]
		public string SerialNumber
		{
			get;
			set;
		}

		[XmlElement("start_date")]
		public string StartDate
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

		[XmlElement("strip")]
		public string Strip
		{
			get;
			set;
		}

		[XmlElement("tpl_id")]
		public string TplId
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

		[XmlElement("user_id")]
		public string UserId
		{
			get;
			set;
		}
	}
}
