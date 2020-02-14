using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class BPOpenApiInstance : AopObject
	{
		[XmlElement("biz_context")]
		public string BizContext
		{
			get;
			set;
		}

		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("create_user")]
		public string CreateUser
		{
			get;
			set;
		}

		[XmlElement("description")]
		public string Description
		{
			get;
			set;
		}

		[XmlElement("duration")]
		public long Duration
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_end")]
		public string GmtEnd
		{
			get;
			set;
		}

		[XmlElement("gmt_modified")]
		public string GmtModified
		{
			get;
			set;
		}

		[XmlElement("ip_role_id")]
		public string IpRoleId
		{
			get;
			set;
		}

		[XmlElement("modify_user")]
		public string ModifyUser
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

		[XmlElement("parent_id")]
		public string ParentId
		{
			get;
			set;
		}

		[XmlElement("parent_node")]
		public string ParentNode
		{
			get;
			set;
		}

		[XmlElement("priority")]
		public long Priority
		{
			get;
			set;
		}

		[XmlElement("puid")]
		public string Puid
		{
			get;
			set;
		}

		[XmlElement("source_id")]
		public string SourceId
		{
			get;
			set;
		}

		[XmlElement("source_node_name")]
		public string SourceNodeName
		{
			get;
			set;
		}

		[XmlElement("state")]
		public string State
		{
			get;
			set;
		}

		[XmlArray("tasks")]
		[XmlArrayItem("b_p_open_api_task")]
		public List<BPOpenApiTask> Tasks
		{
			get;
			set;
		}
	}
}
