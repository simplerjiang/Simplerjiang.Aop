using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayBossBaseProcessTaskProcessModel : AopObject
	{
		[XmlElement("context")]
		public string Context
		{
			get;
			set;
		}

		[XmlElement("idempotent_id")]
		public string IdempotentId
		{
			get;
			set;
		}

		[XmlElement("memo")]
		public string Memo
		{
			get;
			set;
		}

		[XmlElement("node")]
		public string Node
		{
			get;
			set;
		}

		[XmlElement("operate")]
		public string Operate
		{
			get;
			set;
		}

		[XmlElement("operator")]
		public string Operator
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

		[XmlArray("sub_contexts")]
		[XmlArrayItem("string")]
		public List<string> SubContexts
		{
			get;
			set;
		}
	}
}
