using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayBossBaseProcessInstanceCreateModel : AopObject
	{
		[XmlArray("add_sign_content")]
		[XmlArrayItem("b_p_open_api_add_sign_content")]
		public List<BPOpenApiAddSignContent> AddSignContent
		{
			get;
			set;
		}

		[XmlElement("context")]
		public string Context
		{
			get;
			set;
		}

		[XmlElement("creator")]
		public string Creator
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

		[XmlElement("ip_role_id")]
		public string IpRoleId
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

		[XmlElement("priority")]
		public long Priority
		{
			get;
			set;
		}

		[XmlElement("puid")]
		public BPOpenApiPUID Puid
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

		[XmlElement("source_puid")]
		public string SourcePuid
		{
			get;
			set;
		}

		[XmlArray("sub_contexts")]
		[XmlArrayItem("string")]
		public List<string> SubContexts
		{
			get;
			set;
		}
	}
}
