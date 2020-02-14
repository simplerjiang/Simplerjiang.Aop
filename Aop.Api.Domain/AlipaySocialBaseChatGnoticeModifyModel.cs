using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseChatGnoticeModifyModel : AopObject
	{
		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}

		[XmlElement("group_notice")]
		public string GroupNotice
		{
			get;
			set;
		}
	}
}
