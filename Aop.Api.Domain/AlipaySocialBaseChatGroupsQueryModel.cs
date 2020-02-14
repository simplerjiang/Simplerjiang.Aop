using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseChatGroupsQueryModel : AopObject
	{
		[XmlElement("last_key")]
		public long LastKey
		{
			get;
			set;
		}
	}
}
