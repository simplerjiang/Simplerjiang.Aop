using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseChatGroupCreateModel : AopObject
	{
		[XmlElement("client_id")]
		public string ClientId
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
