using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseChatGnameModifyModel : AopObject
	{
		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}

		[XmlElement("group_name")]
		public string GroupName
		{
			get;
			set;
		}
	}
}
