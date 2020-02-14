using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayIserviceItaskProcessDetailModifyModel : AopObject
	{
		[XmlElement("app_name")]
		public string AppName
		{
			get;
			set;
		}

		[XmlElement("attachment")]
		public string Attachment
		{
			get;
			set;
		}

		[XmlElement("exapp_name")]
		public string ExappName
		{
			get;
			set;
		}

		[XmlElement("exsystem_department_id")]
		public string ExsystemDepartmentId
		{
			get;
			set;
		}

		[XmlElement("exsystem_department_name")]
		public string ExsystemDepartmentName
		{
			get;
			set;
		}

		[XmlElement("exsystem_operate")]
		public string ExsystemOperate
		{
			get;
			set;
		}

		[XmlElement("exsystem_operator_comment")]
		public string ExsystemOperatorComment
		{
			get;
			set;
		}

		[XmlElement("exsystem_operator_id")]
		public string ExsystemOperatorId
		{
			get;
			set;
		}

		[XmlElement("exsystem_operator_name")]
		public string ExsystemOperatorName
		{
			get;
			set;
		}

		[XmlArray("extend_field_infos")]
		[XmlArrayItem("extend_field_info")]
		public List<ExtendFieldInfo> ExtendFieldInfos
		{
			get;
			set;
		}

		[XmlElement("process_no")]
		public string ProcessNo
		{
			get;
			set;
		}

		[XmlElement("process_template_code")]
		public string ProcessTemplateCode
		{
			get;
			set;
		}

		[XmlElement("process_unique_id")]
		public string ProcessUniqueId
		{
			get;
			set;
		}
	}
}
