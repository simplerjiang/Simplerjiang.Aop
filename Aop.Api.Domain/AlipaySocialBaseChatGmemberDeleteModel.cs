using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseChatGmemberDeleteModel : AopObject
	{
		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}

		[XmlArray("uids")]
		[XmlArrayItem("string")]
		public List<string> Uids
		{
			get;
			set;
		}
	}
}
