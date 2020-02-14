using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipaySocialBaseChatGinfoQueryModel : AopObject
	{
		[XmlElement("group_id")]
		public string GroupId
		{
			get;
			set;
		}
	}
}
